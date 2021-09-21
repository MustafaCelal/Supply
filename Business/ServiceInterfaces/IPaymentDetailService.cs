using Entities.DTOs;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.ServiceInterfaces
{
    public interface IPaymentDetailService
    {
        List<PaymentDetail> GetAll(Expression<Func<PaymentDetail, bool>> filter = null);
        PaymentDetail GetById(int id);
        void Add(PaymentDetail paymentDetail);
        void Update(PaymentDetail paymentDetail);
        void Delete(PaymentDetail paymentDetail);
        void DeleteMultiple(IEnumerable<PaymentDetail> paymentDetails);
        PaymentDetailDto GetByIdWithSupplyDetail(int id);
        List<PaymentDetailDto> GetAllWithSupplyDetail(Expression<Func<PaymentDetail, bool>> filter = null);
    }
}
