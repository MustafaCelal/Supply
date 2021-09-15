using Business.ServiceInterfaces;
using DataAccess.RepositoryInterfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Services
{
    public class OrderService : IOrderService
    {
        IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void Add(Order entity)
        {
            _orderRepository.Add(entity);
        }

        public void Delete(Order entity)
        {
            _orderRepository.Delete(entity);
        }

        public void DeleteMultiple(IEnumerable<Order> entities)
        {
            _orderRepository.DeleteMultiple(entities);
        }

        public Order Get(Expression<Func<Order, bool>> filter)
        {
            return _orderRepository.Get(filter);
        }

        public List<Order> GetAll(Expression<Func<Order, bool>> filter = null)
        {
            return _orderRepository.GetAll(filter);
        }

        public void Update(Order entity)
        {
            _orderRepository.Update(entity);
        }
    }

}
