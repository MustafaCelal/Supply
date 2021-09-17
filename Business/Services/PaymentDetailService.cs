using Business.ServiceInterfaces;
using DataAccess.RepositoryInterfaces;
using Entities.DTOs.PaymentDetailDTOs;
using Entities.Models;
using System;
using System.Collections.Generic;
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

        public PaymentDetailDto GetById(int id)
        {
            var payments=_paymentDetailRepository.Get(pd => pd.Id == id);
            var supplyDetails = _supplyService.GetById(payments.SupplyId);

            return new PaymentDetailDto
            {
                Id = id,
                LastDept = payments.LastDept,
                PreviousDept = payments.PreviousDept,
                RecievedMoney = payments.RecievedMoney,
                SupplyId = supplyDetails.Id,
                Price = supplyDetails.TotalPrice,
                SupplyDate = supplyDetails.SupplyDate
            };
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
