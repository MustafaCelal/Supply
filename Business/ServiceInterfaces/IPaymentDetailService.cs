using Entities.DTOs;
using Entities.Models;
using System.Collections.Generic;

namespace Business.ServiceInterfaces
{
    public interface IPaymentDetailService
    {
        List<PaymentDetailDto> GetAll();
        PaymentDetailDto GetById(int id);
        void Add(PaymentDetail paymentDetail);
        void Update(PaymentDetail paymentDetail);
        void Delete(PaymentDetail paymentDetail);
        void DeleteMultiple(IEnumerable<PaymentDetail> paymentDetails);
    }
}
