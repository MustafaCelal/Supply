using DataAccess.RepositoryInterfaces;
using Entities.Models;

namespace DataAccess.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context):base(context)
        {
        }
    }
}
