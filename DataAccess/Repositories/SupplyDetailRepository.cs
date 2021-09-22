using DataAccess.RepositoryInterfaces;
using Entities.DTOs;
using Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Repositories
{
    public class SupplyDetailRepository : BaseRepository<SupplyDetail, AppDbContext>, ISupplyDetailRepository
    {
        public List<SupplyDetailDto> GetAllWithDetail()
        {
            using (AppDbContext context = new())
            {

                var supplyDetails = context.Set<SupplyDetail>().ToList();
                var supplyDates = context.Set<Supply>().ToList();
                var productNames = context.Set<Product>().ToList();

                var res = from sp in supplyDetails
                          join sd in supplyDates on sp.SupplyId equals sd.Id
                          join p in productNames on sp.ProductId equals p.Id
                          select new SupplyDetailDto
                          {
                              Id = sp.Id,
                              ProductId = p.Id,
                              ProductName = p.Name,
                              Quantity = sp.Quantity,
                              SupplyId = sd.Id,
                              SupplyDate = sd.SupplyDate,
                              UnitPrice = p.UnitPrice
                          };
                return res.ToList();
            }
        }

        public SupplyDetailDto GetByIdWithDetail(int id)
        {
            using (AppDbContext context = new())
            {
                //var supplyDetails = context.Set<SupplyDetail>().ToList();

                var supplyProduct = context.Set<SupplyDetail>().FirstOrDefault(sp => sp.Id == id);
                if (supplyProduct==null)
                {
                    return null;
                }
                
                var supply = context.Set<Supply>().FirstOrDefault(x => x.Id == supplyProduct.SupplyId);
                
                if (supply==null)
                {
                    return null;
                }
                
                var product = context.Set<Product>().FirstOrDefault(x => x.Id == supplyProduct.ProductId);

                return new SupplyDetailDto
                {
                    Id = supplyProduct.Id,
                    ProductId = product.Id,
                    ProductName = product.Name,
                    Quantity = supplyProduct.Quantity,
                    SupplyId = supply.Id,
                    SupplyDate = supply.SupplyDate,
                    UnitPrice = supplyProduct.UnitPrice
                };
            }
        }
    }
}
