using Business.ServiceInterfaces;
using DataAccess.RepositoryInterfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Services
{
    public class CustomerService : ICustomerService
    {
        ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void Add(Customer entity)
        {
            _customerRepository.Add(entity);
        }

        public void Delete(Customer entity)
        {
            _customerRepository.Delete(entity);
        }

        public void DeleteMultiple(IEnumerable<Customer> entities)
        {
            _customerRepository.DeleteMultiple(entities);
        }

        public Customer GetById(int id)
        {
            return _customerRepository.Get(c=>c.Id==id);
        }

        public List<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }

        public void Update(Customer entity)
        {
            _customerRepository.Update(entity);
        }
    }

}
