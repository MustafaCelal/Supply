using DataAccess.RepositoryInterfaces;
using Entities.Models;

namespace DataAccess.Repositories
{
    public class PaymentDetailRepository : BaseRepository<PaymentDetail, AppDbContext>, IPaymentDetailRepository
    {
        
    }
}
