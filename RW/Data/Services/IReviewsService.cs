using Review_Website.Models;

namespace Review_Website.Data.Services
{
    public interface IReviewsService
    {
        
        Task<IEnumerable<Review>> GetAllAsync();

        Task<Review> GetByIdAsync(int id);

        Task AddAsync(Review review);

        Task<Review> UpdateAsync(int id, Review review);

        Task DeleteAsync(int id);
        
    }
}
