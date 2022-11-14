using System.Linq;
using System.Threading.Tasks;

namespace Web_Labs.Models
{
    public interface IDataModels
    {
        IQueryable<AccordoinModel> Models { get; }
        Task SaveChanges();
        public Task AddOrEdit (AccordoinModel model);
    }
}
