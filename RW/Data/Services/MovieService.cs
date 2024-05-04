using Microsoft.EntityFrameworkCore;
using Review_Website.Models;
using System.Security.Cryptography.X509Certificates;

namespace Review_Website.Data.Services
{
    public class MovieService: IMovieService
    {
        private readonly AppDbContext context;

        public MovieService(AppDbContext context)
        {
            this.context = context;
        }

        async Task IMovieService.AddAsync(Movie movie)
        {
            await context.Movies.AddAsync(movie);
            await context.SaveChangesAsync();
        }

        async Task IMovieService.DeleteAsync(int id)
        {
            var result = await context.Movies.FirstOrDefaultAsync(n => n.Id == id);
            context.Movies.Remove(result);
            await context.SaveChangesAsync();
        }

        async Task<IEnumerable<Movie>> IMovieService.GetAllAsync()
        {
            var allMovies = await context.Movies.ToListAsync();
            return allMovies;
        }

        async Task<Movie> IMovieService.GetByIdAsync(int id)
        {
            var result = await context.Movies.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        async Task<Movie> IMovieService.UpdateAsync(int id, Movie newMovie)
        {
            context.Update(newMovie);
            await context.SaveChangesAsync();
            return newMovie;
        }
    }
}
