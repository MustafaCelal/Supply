using DataAccess.RepositoryInterfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Repositories
{
    public class BaseRepository<TEntity,TContext> : IEntityRepository<TEntity> 
        where TEntity : class, IEntity, new()
        where TContext:DbContext,new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new())
            {
                context.Set<TEntity>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new())
            {
                context.Set<TEntity>().Remove(entity);
                context.SaveChanges();
            }
        }
        public void DeleteMultiple(IEnumerable<TEntity> entities)
        {
            using (TContext context = new())
            {
                context.Set<TEntity>().RemoveRange(entities);
                context.SaveChanges();
            }
        }
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new())
            {
                return filter == null
                ? context.Set<TEntity>().ToList()
                : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new())
            {
                context.Set<TEntity>().Update(entity);
                context.SaveChanges();
            }

            //_context.Entry(entity).State = EntityState.Modified;
        }
    }
}
