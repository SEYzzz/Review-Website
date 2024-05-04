using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Review_Website.Data;
using Review_Website.Data.Services;
using Review_Website.Models;

namespace Review_Website.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducersService service;

        public ProducersController(IProducersService service)
        {
            this.service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allProducers = await service.GetAllAsync();
            return View(allProducers);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")] Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }
            else
            {
                await service.AddAsync(producer);
            }
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await service.GetByIdAsync(id);

            if (producerDetails == null)
            {
                return View("NotFound");
            }
            else
            {
                return View(producerDetails);
            }
        }


        public async Task<IActionResult> Edit(int id)
        {
            var producersDetails = await service.GetByIdAsync(id);
            if (producersDetails == null) return View("NotFound");
            return View(producersDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePictureURL,Bio")] Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }
            else
            {
                await service.UpdateAsync(id, producer);
            }
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int id)
        {
            var producerDetails = await service.GetByIdAsync(id);
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producerDetails = await service.GetByIdAsync(id);
            if (producerDetails == null) return View("NotFound");

            await service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
