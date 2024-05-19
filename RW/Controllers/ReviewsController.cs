using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Review_Website.Data;
using Review_Website.Data.Services;

namespace Review_Website.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly IReviewsService service;

        public ReviewsController(IReviewsService service)
        {
            this.service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allReviews = await service.GetAllAsync();
            return View(allReviews);
        }

        public async Task<IActionResult> Details(int id)
        {
            var reviewDetails = await service.GetByIdAsync(id);

            if (reviewDetails == null)
            {
                return View("NotFound");
            }
            else
            {
                return View(reviewDetails);
            }
        }
    }
}
