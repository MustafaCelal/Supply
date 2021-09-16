using Entities.Models;
using System.Collections.Generic;

namespace Business.ServiceInterfaces
{
    public interface IPaymentDetailService
    {
        List<PaymentDetail> GetAll();
        PaymentDetail GetById(int id);
        void Add(PaymentDetail paymentDetail);
        void Update(PaymentDetail paymentDetail);
        void Delete(PaymentDetail paymentDetail);
        void DeleteMultiple(IEnumerable<PaymentDetail> paymentDetails);
    }
}
