using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.ServiceInterfaces
{
    public interface IService<TEntity> where TEntity : class, IEntity, new()
    {
        List<TEntity> GetAll();
        TEntity GetById(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void DeleteMultiple(IEnumerable<TEntity> entities);
    }
}
