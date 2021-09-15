using DataAccess.RepositoryInterfaces;
using Entities.Models;

namespace DataAccess.Repositories
{
    public class OrderPayDetailRepository : BaseRepository<OrderPayDetail>, IOrderPayDetailRepository
    {
        public OrderPayDetailRepository(AppDbContext context):base(context)
        {
        }
    }
}
