using Entities.DTOs;
using Entities.Models;
using System.Collections.Generic;

namespace Business.ServiceInterfaces
{
    public interface ISupplyService
    {
        List<SupplyDto> GetAll();
        SupplyDto GetById(int id);
        void Add(Supply supply);
        void Update(Supply supply);
        void Delete(Supply supply);
        void DeleteMultiple(IEnumerable<Supply> supplies);
    }
}
