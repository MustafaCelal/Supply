using Entities.Models;
using System.Collections.Generic;

namespace Business.ServiceInterfaces
{
    public interface ISupplyService
    {
        List<Supply> GetAll();
        Supply GetById(int id);
        void Add(Supply supply);
        void Update(Supply supply);
        void Delete(Supply supply);
        void DeleteMultiple(IEnumerable<Supply> supplies);
    }
}
