using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Web_Labs.Models
{
    public class EFModelsRepository : IDataModels
    {
        AppDbContext context;
        public EFModelsRepository(AppDbContext context)
        {
            this.context = context;
        }
        public IQueryable<AccordoinModel> Models => context.Models;

        public async Task AddOrEdit(AccordoinModel model)
        {
            AccordoinModel current = context.Models.Where(m => m.Position == model.Position).FirstOrDefault();
            if (current == null)
            {
                current = new AccordoinModel { Position = model.Position };
                await context.Models.AddAsync(current);
            }
            current.Content = model.Content;
            await SaveChanges();
        }

        public async Task SaveChanges()
        {
            await context.SaveChangesAsync();
        }
    }
}
