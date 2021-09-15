using Business.ServiceInterfaces;
using DataAccess.RepositoryInterfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Services
{
    public class OrderDetailService : IOrderDetailService
    {
        IOrderDetailRepository _orderDetailRepository;

        public OrderDetailService(IOrderDetailRepository orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }

        public void Add(OrderDetail entity)
        {
            _orderDetailRepository.Add(entity);
        }

        public void Delete(OrderDetail entity)
        {
            _orderDetailRepository.Delete(entity);
        }

        public void DeleteMultiple(IEnumerable<OrderDetail> entities)
        {
            _orderDetailRepository.DeleteMultiple(entities);
        }

        public OrderDetail GetById(int id)
        {
            return _orderDetailRepository.Get(od=>od.Id==id);
        }

        public List<OrderDetail> GetAll()
        {
            return _orderDetailRepository.GetAll();
        }

        public void Update(OrderDetail entity)
        {
            _orderDetailRepository.Update(entity);
        }
    }

}
