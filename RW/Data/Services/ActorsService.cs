using Microsoft.EntityFrameworkCore;
using Review_Website.Models;

namespace Review_Website.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext context;

        public ActorsService(AppDbContext context)
        {
                this.context = context;
        }

        async Task IActorsService.AddAsync(Actor actor)
        {
            await context.Actors.AddAsync(actor);
            await context.SaveChangesAsync();
        }

        async Task IActorsService.DeleteAsync(int id)
        {
            var result = await context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            context.Actors.Remove(result);
            await context.SaveChangesAsync();
        }

        async Task<IEnumerable<Actor>> IActorsService.GetAllAsync()
        {
            var result = await context.Actors.ToListAsync();
            return result;
        }

        async Task<Actor> IActorsService.GetByIdAsync(int id)
        {
            var result = await context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        async Task<Actor> IActorsService.UpdateAsync(int id, Actor newActor)
        {
            context.Update(newActor);
            await context.SaveChangesAsync();
            return newActor;
        }
    }
}
