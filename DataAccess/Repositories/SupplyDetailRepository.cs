using DataAccess.RepositoryInterfaces;
using Entities.Models;

namespace DataAccess.Repositories
{
    public class SupplyDetailRepository : BaseRepository<SupplyDetail, AppDbContext>, ISupplyDetailRepository
    {
        
    }
}
