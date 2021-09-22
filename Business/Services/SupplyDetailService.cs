using Business.ServiceInterfaces;
using DataAccess.RepositoryInterfaces;
using Entities.DTOs;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Business.Services
{
    public class SupplyDetailService : ISupplyDetailService
    {
        private readonly ISupplyDetailRepository _supplyDetailRepository;
        private readonly ISupplyService _supplyService;
        private readonly IProductService _productService;
        public SupplyDetailService(ISupplyDetailRepository supplyDetailRepository, ISupplyService supplyService, IProductService productService)
        {
            _supplyDetailRepository = supplyDetailRepository;
            _supplyService = supplyService;
            _productService = productService;
        }

        public void Add(SupplyDetail entity)
        {
            _supplyDetailRepository.Add(entity);
        }

        public void Delete(SupplyDetail entity)
        {
            _supplyDetailRepository.Delete(entity);
        }

        public void DeleteMultiple(IEnumerable<SupplyDetail> entities)
        {
            _supplyDetailRepository.DeleteMultiple(entities);
        }

        public SupplyDetail GetById(int id)
        {
            return _supplyDetailRepository.Get(sp => sp.Id == id);
        }
        
        public SupplyDetailDto GetByIdWithDetail(int id)
        {
            return _supplyDetailRepository.GetByIdWithDetail(id);
        }

        public List<SupplyDetail> GetAll()
        {
            return _supplyDetailRepository.GetAll();
        }
        
        public List<SupplyDetailDto> GetAllWithDetail()
        {
            return _supplyDetailRepository.GetAllWithDetail();
        }

        public void Update(SupplyDetail entity)
        {
            _supplyDetailRepository.Update(entity);
        }
    }

}
