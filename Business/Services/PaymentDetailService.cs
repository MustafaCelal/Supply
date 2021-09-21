using Business.ServiceInterfaces;
using DataAccess.RepositoryInterfaces;
using Entities.DTOs;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Business.Services
{
    public class PaymentDetailService : IPaymentDetailService
    {
        IPaymentDetailRepository _paymentDetailRepository;
        ISupplyService _supplyService;
        public PaymentDetailService(IPaymentDetailRepository paymentDetailRepository,ISupplyService supplyService)
        {
            _paymentDetailRepository = paymentDetailRepository;
            _supplyService = supplyService;
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
       
        public void Update(PaymentDetail entity)
        {
            _paymentDetailRepository.Update(entity);
        }

        public List<PaymentDetail> GetAll(Expression<Func<PaymentDetail, bool>> filter = null)
        {
            return _paymentDetailRepository.GetAll(filter);
        }
        
        public PaymentDetail GetById(int id)
        {
            return _paymentDetailRepository.GetById(id);
        }

        public PaymentDetailDto GetByIdWithSupplyDetail(int id)
        {
            return _paymentDetailRepository.GetByIdWithSupplyDetail(id);
        }
        
        public List<PaymentDetailDto> GetAllWithSupplyDetail(Expression<Func<PaymentDetail, bool>> filter = null)
        {
            return _paymentDetailRepository.GetAllWithSupplyDetail(filter);
            
        }

    }

}
