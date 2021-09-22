using Entities.DTOs;
using Entities.Models;
using System.Collections.Generic;

namespace Business.ServiceInterfaces
{
    public interface ISupplyDetailService
    {
        List<SupplyDetail> GetAll();
        List<SupplyDetailDto> GetAllWithDetail();
        SupplyDetail GetById(int id);
        SupplyDetailDto GetByIdWithDetail(int id);
        void Add(SupplyDetail supplyDetail);
        void Update(SupplyDetail supplyDetail);
        void Delete(SupplyDetail supplyDetail);
        void DeleteMultiple(IEnumerable<SupplyDetail> supplyDetails);
    }
}
