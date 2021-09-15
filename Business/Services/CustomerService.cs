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

        public Customer Get(Expression<Func<Customer, bool>> filter)
        {
            return _customerRepository.Get(filter);
        }

        public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            return _customerRepository.GetAll(filter);
        }

        public void Update(Customer entity)
        {
            _customerRepository.Update(entity);
        }
    }

}
