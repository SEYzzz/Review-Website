using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Review_Website.Data;
using Review_Website.Data.Services;
using Review_Website.Models;

namespace Review_Website.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieService service;

        public MoviesController(IMovieService service)
        {
            this.service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allMovies = await service.GetAllAsync();
            return View(allMovies);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Title,PictureURL,Description,ProducerId,Genre,ReleaseDate")]Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return View(movie);
            }
            else
            {
                await service.AddAsync(movie);
            }
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            var movieDetails = await service.GetByIdAsync(id);

            if (movieDetails == null)
            {
                return View("NotFound");
            }
            else
            {
                return View(movieDetails);
            }
        }


        public async Task<IActionResult> Edit(int id)
        {
            var movieDetails = await service.GetByIdAsync(id);
            if (movieDetails == null) return View("NotFound");
            return View(movieDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,PictureURL,Description, Genre, ReleaseDate")] Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return View(movie);
            }
            else
            {
                await service.UpdateAsync(id, movie);
            }
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int id)
        {
            var movieDetails = await service.GetByIdAsync(id);
            if (movieDetails == null) return View("NotFound");
            return View(movieDetails);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movieDetails = await service.GetByIdAsync(id);
            if (movieDetails == null) return View("NotFound");

            await service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        public ActionResult Filter(string searchString)
        {
            var allMovies =  service.GetBySearchString(searchString);

            if (allMovies == null) return View("NotFound");
            return View(allMovies);
        }
    }
}
