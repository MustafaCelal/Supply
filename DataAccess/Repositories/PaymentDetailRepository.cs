using DataAccess.RepositoryInterfaces;
using Entities.DTOs;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Repositories
{
    public class PaymentDetailRepository : BaseRepository<PaymentDetail, AppDbContext>, IPaymentDetailRepository
    {
        public List<PaymentDetailDto> GetAllWithSupplyDetail(Expression<Func<PaymentDetail, bool>> filter = null)
        {
            using (AppDbContext context = new())
            {
                var paymentDetails = filter == null
                                    ? context.Set<PaymentDetail>().ToList()
                                    : context.Set<PaymentDetail>().Where(filter).ToList();


                var supply = context.Set<Supply>().ToList();

                var res = paymentDetails.Join(
                       supply, p => p.SupplyId, s => s.Id, (p, s) => new PaymentDetailDto
                       {
                           Id = p.Id,
                           SupplyDate = s.SupplyDate,
                           PreviousDept = p.PreviousDept,
                           Price = s.TotalPrice,
                           RecievedMoney = p.RecievedMoney,
                           RemainingDept = p.RemainingDept,
                           SupplyId = s.Id
                       }).ToList();

                return res;
            }
        }

        public PaymentDetail GetById(int id)
        {
            using (AppDbContext context = new())
            {
                return context.Set<PaymentDetail>().SingleOrDefault(x=>x.Id==id);
            }
        }

        public PaymentDetailDto GetByIdWithSupplyDetail(int id)
        {
            using (AppDbContext context = new())
            {
                var payments = context.Set<PaymentDetail>().SingleOrDefault(x => x.Id == id);
                if (payments != null)
                {
                    var supply = context.Set<Supply>().SingleOrDefault(x => x.Id == payments.SupplyId);


                    return new PaymentDetailDto
                    {
                        Id = id,
                        RemainingDept = payments.RemainingDept,
                        PreviousDept = payments.PreviousDept,
                        RecievedMoney = payments.RecievedMoney,
                        SupplyId = supply.Id,
                        Price = supply.TotalPrice,
                        SupplyDate = supply.SupplyDate
                    };
                }
                else return null;
            }
        }
    }
}
