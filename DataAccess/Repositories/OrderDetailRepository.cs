using DataAccess.RepositoryInterfaces;
using Entities.Models;

namespace DataAccess.Repositories
{
    public class OrderDetailRepository : BaseRepository<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(AppDbContext context):base(context)
        {
        }
    }
}
