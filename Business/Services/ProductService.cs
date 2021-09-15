using Business.ServiceInterfaces;
using DataAccess.RepositoryInterfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Services
{
    public class ProductService : IProductService
    {
        IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Add(Product entity)
        {
            _productRepository.Add(entity);
        }

        public void Delete(Product entity)
        {
            _productRepository.Delete(entity);
        }

        public void DeleteMultiple(IEnumerable<Product> entities)
        {
            _productRepository.DeleteMultiple(entities);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            return _productRepository.Get(filter);
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return _productRepository.GetAll(filter);
        }

        public void Update(Product entity)
        {
            _productRepository.Update(entity);
        }
    }

}
