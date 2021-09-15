using DataAccess.RepositoryInterfaces;
using Entities.Models;

namespace DataAccess.Repositories
{
    public class SupplyRepository : BaseRepository<Supply, AppDbContext>, ISupplyRepository
    {
    }
}
