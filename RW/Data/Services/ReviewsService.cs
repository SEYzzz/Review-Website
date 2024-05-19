using Microsoft.EntityFrameworkCore;
using Review_Website.Models;

namespace Review_Website.Data.Services
{
    public class ReviewsService: IReviewsService
    {
        private readonly AppDbContext context;

        public ReviewsService(AppDbContext context)
        {
            this.context = context;
        }

        async public Task AddAsync(Review review)
        {
            await context.Reviews.AddAsync(review);
            await context.SaveChangesAsync();
        }

        async public Task DeleteAsync(int id)
        {
            var result = await context.Reviews.FirstOrDefaultAsync(n => n.Id == id);
            context.Reviews.Remove(result);
            await context.SaveChangesAsync();
        }

        async public Task<IEnumerable<Review>> GetAllAsync()
        {
            var allReviews = await context.Reviews.ToListAsync();
            return allReviews;
        }

        async public Task<Review> GetByIdAsync(int id)
        {
            var result = await context.Reviews.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        async public Task<Review> UpdateAsync(int id, Review newReview)
        {
            context.Update(newReview);
            await context.SaveChangesAsync();
            return newReview;
        }
    }
}
