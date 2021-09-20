using Business.ServiceInterfaces;
using DataAccess.RepositoryInterfaces;
using Entities.DTOs;
using Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services
{
    public class SupplyService : ISupplyService
    {
        private readonly ISupplyRepository _supplyRepository;
        private readonly ICustomerService _customerService;
        public SupplyService(ISupplyRepository supplyRepository, ICustomerService customerService)
        {
            _supplyRepository = supplyRepository;
            _customerService = customerService;
        }

        public void Add(Supply entity)
        {
            _supplyRepository.Add(entity);
        }

        public void Delete(Supply entity)
        {
            _supplyRepository.Delete(entity);
        }

        public void DeleteMultiple(IEnumerable<Supply> entities)
        {
            _supplyRepository.DeleteMultiple(entities);
        }

        public SupplyDto GetById(int id)
        {
            
            var supply =_supplyRepository.Get(s => s.Id == id);
            var customer = _customerService.GetById(supply.CustomerId);
            return new SupplyDto
            {
                Id = supply.Id,
                CustomerId = customer.Id,
                TotalPrice = supply.TotalPrice,
                SupplyDate = supply.SupplyDate,
                Customer = customer.Name + "/" + customer.CompanyName
            };
        }

        public List<SupplyDto> GetAll()
        {
            var supplies = _supplyRepository.GetAll();
            var customers = _customerService.GetAll();
            var res = from s in supplies
                      join c in customers
                      on s.CustomerId equals c.Id
                      select new SupplyDto
                      {
                          Id = s.Id,
                          CustomerId = c.Id,
                          TotalPrice = s.TotalPrice,
                          SupplyDate = s.SupplyDate,
                          Customer = c.CompanyName + "/" + c.Name
                      };
            return res.ToList();
        }

        public void Update(Supply entity)
        {
            _supplyRepository.Update(entity);
        }
    }

}
