using Entities.DTOs;
using Entities.Models;
using System.Collections.Generic;

namespace Business.ServiceInterfaces
{
    public interface ISupplyDetailService
    {
        List<SupplyDetailDto> GetAll();
        SupplyDetailDto GetById(int id);
        void Add(SupplyDetail supplyDetail);
        void Update(SupplyDetail supplyDetail);
        void Delete(SupplyDetail supplyDetail);
        void DeleteMultiple(IEnumerable<SupplyDetail> supplyDetails);
    }
}
