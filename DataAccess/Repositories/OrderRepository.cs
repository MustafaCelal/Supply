using DataAccess.RepositoryInterfaces;
using Entities.Models;

namespace DataAccess.Repositories
{
    public class OrderRepository : BaseRepository<Order,AppDbContext>, IOrderRepository
    {
    }
}
