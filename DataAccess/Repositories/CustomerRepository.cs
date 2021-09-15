using DataAccess.RepositoryInterfaces;
using Entities.Models;

namespace DataAccess.Repositories
{

    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(AppDbContext context):base(context)
        {
        }
    }
}
