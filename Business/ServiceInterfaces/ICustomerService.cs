using Entities.Models;
using System.Collections.Generic;

namespace Business.ServiceInterfaces
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetById(int id);
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
        void DeleteMultiple(IEnumerable<Customer> customers);
    }
}
