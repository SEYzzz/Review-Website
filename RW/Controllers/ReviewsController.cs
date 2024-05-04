using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Review_Website.Data;

namespace Review_Website.Controllers
{
    public class ReviewsController : Controller
    {
        public readonly AppDbContext _context;

        public ReviewsController(AppDbContext contex)
        {
                _context = contex;
        }

        public async Task<IActionResult> Index()
        {
            var allReviews = await _context.Reviews.ToListAsync();
            return View();
        }
    }
}
