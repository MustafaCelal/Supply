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
    public class SupplyProductService : ISupplyProductService
    {
        ISupplyProductRepository _supplyProductRepository;
        ISupplyService _supplyService;
        IProductService _productService;
        public SupplyProductService(ISupplyProductRepository supplyProductRepository, ISupplyService supplyService, IProductService productService)
        {
            _supplyProductRepository = supplyProductRepository;
            _supplyService = supplyService;
            _productService = productService;
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

        public SupplyProductDto GetById(int id)
        {
            var supplyProduct=_supplyProductRepository.Get(sp => sp.Id == id);
            var supply = _supplyService.GetById(supplyProduct.SupplyId);
            var product = _productService.GetById(supplyProduct.ProductId);

            return new SupplyProductDto {
                Id = supplyProduct.Id, 
                ProductId=product.Id,
                ProductName = product.Name,
                Quantity = supplyProduct.Quantity,
                SupplyId=supply.Id,
                SupplyDate = supply.SupplyDate, 
                UnitPrice = supplyProduct.UnitPrice 
            };
            
        }

        public List<SupplyProductDto> GetAll()
        {
            var supplyProducts = _supplyProductRepository.GetAll();
            var supplyDates = _supplyService.GetAll();
            var productNames = _productService.GetAll();

            var res = from sp in supplyProducts
                      join sd in supplyDates on sp.SupplyId equals sd.Id
                      join p in productNames on sp.ProductId equals p.Id
                      select new SupplyProductDto
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

        public void Update(SupplyProduct entity)
        {
            _supplyProductRepository.Update(entity);
        }
    }

}
