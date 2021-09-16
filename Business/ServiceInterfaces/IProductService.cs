using Entities.Models;
using System.Collections.Generic;

namespace Business.ServiceInterfaces
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        void DeleteMultiple(IEnumerable<Product> products);
    }
}
