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

        public SupplyDetailDto GetById(int id)
        {
            var supplyProduct=_supplyDetailRepository.Get(sp => sp.Id == id);
            var supply = _supplyService.GetById(supplyProduct.SupplyId);
            var product = _productService.GetById(supplyProduct.ProductId);

            return new SupplyDetailDto {
                Id = supplyProduct.Id, 
                ProductId=product.Id,
                ProductName = product.Name,
                Quantity = supplyProduct.Quantity,
                SupplyId=supply.Id,
                SupplyDate = supply.SupplyDate, 
                UnitPrice = supplyProduct.UnitPrice 
            };
            
        }

        public List<SupplyDetailDto> GetAll()
        {
            var supplyDetails = _supplyDetailRepository.GetAll();
            var supplyDates = _supplyService.GetAll();
            var productNames = _productService.GetAll();

            var res = from sp in supplyDetails
                      join sd in supplyDates on sp.SupplyId equals sd.Id
                      join p in productNames on sp.ProductId equals p.Id
                      select new SupplyDetailDto
                      {
                          Id = sp.Id,
                          ProductId=p.Id,
                          ProductName = p.Name,
                          Quantity = sp.Quantity,
                          SupplyId=sd.Id,
                          SupplyDate = sd.SupplyDate,
                          UnitPrice = p.UnitPrice
                      };
            return res.ToList();
        }

        public void Update(SupplyDetail entity)
        {
            _supplyDetailRepository.Update(entity);
        }
    }

}
