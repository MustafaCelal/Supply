using Business.ServiceInterfaces;
using DataAccess.RepositoryInterfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Services
{
    public class OrderPayDetailService : IOrderPayDetailService
    {
        IOrderPayDetailRepository _orderPayDetailRepository;

        public OrderPayDetailService(IOrderPayDetailRepository orderPayDetailRepository)
        {
            _orderPayDetailRepository = orderPayDetailRepository;
        }

        public void Add(OrderPayDetail entity)
        {
            _orderPayDetailRepository.Add(entity);
        }

        public void Delete(OrderPayDetail entity)
        {
            _orderPayDetailRepository.Delete(entity);
        }

        public void DeleteMultiple(IEnumerable<OrderPayDetail> entities)
        {
            _orderPayDetailRepository.DeleteMultiple(entities);
        }

        public OrderPayDetail Get(Expression<Func<OrderPayDetail, bool>> filter)
        {
            return _orderPayDetailRepository.Get(filter);
        }

        public List<OrderPayDetail> GetAll(Expression<Func<OrderPayDetail, bool>> filter = null)
        {
            return _orderPayDetailRepository.GetAll(filter);
        }

        public void Update(OrderPayDetail entity)
        {
            _orderPayDetailRepository.Update(entity);
        }
    }

}
