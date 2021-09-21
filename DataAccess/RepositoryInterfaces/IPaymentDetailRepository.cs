using Entities.DTOs;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.RepositoryInterfaces
{
    public interface IPaymentDetailRepository : IEntityRepository<PaymentDetail>
    {
        PaymentDetail GetById(int id);
        PaymentDetailDto GetByIdWithSupplyDetail(int id);
        List<PaymentDetailDto> GetAllWithSupplyDetail(Expression<Func<PaymentDetail, bool>> filter = null);
    }

}
