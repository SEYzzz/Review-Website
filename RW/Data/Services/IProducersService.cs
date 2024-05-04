using Review_Website.Models;

namespace Review_Website.Data.Services
{
    public interface IProducersService
    {
        Task<IEnumerable<Producer>> GetAllAsync();

        Task<Producer> GetByIdAsync(int id);

        Task AddAsync(Producer producer);

        Task<Producer> UpdateAsync(int id, Producer newProdcer);

        Task DeleteAsync(int id);
    }
}
