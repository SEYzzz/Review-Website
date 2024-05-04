using Microsoft.EntityFrameworkCore;
using Review_Website.Models;

namespace Review_Website.Data.Services
{
    public class ProducersService: IProducersService
    {
        private readonly AppDbContext context;

        public ProducersService(AppDbContext context)
        {
                this.context = context;
        }

        async Task IProducersService.AddAsync(Producer producer)
        {
            await context.Producers.AddAsync(producer);
            await context.SaveChangesAsync();
        }

        async Task IProducersService.DeleteAsync(int id)
        {
            var result = await context.Producers.FirstOrDefaultAsync(n => n.Id == id);
            context.Producers.Remove(result);
            await context.SaveChangesAsync();
        }

        async Task<IEnumerable<Producer>> IProducersService.GetAllAsync()
        {
            var result = await context.Producers.ToListAsync();
            return result;
        }

        async Task<Producer> IProducersService.GetByIdAsync(int id)
        {
            var result = await context.Producers.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        async Task<Producer> IProducersService.UpdateAsync(int id, Producer newProducer)
        {
            context.Update(newProducer);
            await context.SaveChangesAsync();
            return newProducer;
        }
    }
}
