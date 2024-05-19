using Review_Website.Models;

namespace Review_Website.Data.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetAllAsync();

        Task<Movie> GetByIdAsync(int id);

        Task AddAsync(Movie movie);

        Task<Movie> UpdateAsync(int id, Movie newMovie);

        Task DeleteAsync(int id);

        IEnumerable<Movie> GetBySearchString(string searchString);
    }
}
