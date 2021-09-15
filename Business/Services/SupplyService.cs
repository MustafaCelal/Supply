using Business.ServiceInterfaces;
using DataAccess.RepositoryInterfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Services
{
    public class SupplyService : ISupplyService
    {
        ISupplyRepository _supplyRepository;

        public SupplyService(ISupplyRepository supplyRepository)
        {
            _supplyRepository = supplyRepository;
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

        public Supply GetById(int id)
        {
            return _supplyRepository.Get(s=>s.Id==id);
        }

        public List<Supply> GetAll()
        {
            return _supplyRepository.GetAll();
        }

        public void Update(Supply entity)
        {
            _supplyRepository.Update(entity);
        }
    }

}
