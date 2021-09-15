using Business.ServiceInterfaces;
using DataAccess.RepositoryInterfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Services
{
    public class PaymentDetailService : IPaymentDetailService
    {
        IPaymentDetailRepository _paymentDetailRepository;

        public PaymentDetailService(IPaymentDetailRepository paymentDetailRepository)
        {
            _paymentDetailRepository = paymentDetailRepository;
        }

        public void Add(PaymentDetail entity)
        {
            _paymentDetailRepository.Add(entity);
        }

        public void Delete(PaymentDetail entity)
        {
            _paymentDetailRepository.Delete(entity);
        }

        public void DeleteMultiple(IEnumerable<PaymentDetail> entities)
        {
            _paymentDetailRepository.DeleteMultiple(entities);
        }

        public PaymentDetail GetById(int id)
        {
            return _paymentDetailRepository.Get(pd=>pd.Id==id);
        }

        public List<PaymentDetail> GetAll()
        {
            return _paymentDetailRepository.GetAll();
        }

        public void Update(PaymentDetail entity)
        {
            _paymentDetailRepository.Update(entity);
        }
    }

}
