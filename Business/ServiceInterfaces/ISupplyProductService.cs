using Entities.Models;
using System.Collections.Generic;

namespace Business.ServiceInterfaces
{
    public interface ISupplyProductService
    {
        List<SupplyProduct> GetAll();
        SupplyProduct GetById(int id);
        void Add(SupplyProduct supplyProduct);
        void Update(SupplyProduct supplyProduct);
        void Delete(SupplyProduct supplyProduct);
        void DeleteMultiple(IEnumerable<SupplyProduct> supplyProducts);
    }
}
