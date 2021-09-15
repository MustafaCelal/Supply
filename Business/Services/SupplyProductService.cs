using Business.ServiceInterfaces;
using DataAccess.RepositoryInterfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Services
{
    public class SupplyProductService : ISupplyProductService
    {
        ISupplyProductRepository _supplyProductRepository;

        public SupplyProductService(ISupplyProductRepository supplyProductRepository)
        {
            _supplyProductRepository = supplyProductRepository;
        }

        public void Add(SupplyProduct entity)
        {
            _supplyProductRepository.Add(entity);
        }

        public void Delete(SupplyProduct entity)
        {
            _supplyProductRepository.Delete(entity);
        }

        public void DeleteMultiple(IEnumerable<SupplyProduct> entities)
        {
            _supplyProductRepository.DeleteMultiple(entities);
        }

        public SupplyProduct GetById(int id)
        {
            return _supplyProductRepository.Get(sp=>sp.Id==id);
        }

        public List<SupplyProduct> GetAll()
        {
            return _supplyProductRepository.GetAll();
        }

        public void Update(SupplyProduct entity)
        {
            _supplyProductRepository.Update(entity);
        }
    }

}
