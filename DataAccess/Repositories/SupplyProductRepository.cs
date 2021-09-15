using DataAccess.RepositoryInterfaces;
using Entities.Models;

namespace DataAccess.Repositories
{
    public class SupplyProductRepository : BaseRepository<SupplyProduct, AppDbContext>, ISupplyProductRepository
    {
        
    }
}
