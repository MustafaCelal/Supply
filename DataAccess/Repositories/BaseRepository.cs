using DataAccess.RepositoryInterfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Repositories
{
    public class BaseRepository<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        protected readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public BaseRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }
        public void DeleteMultiple(IEnumerable<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
        }
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return _dbSet.SingleOrDefault(filter);
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null
                ? _dbSet.ToList()
                : _dbSet.Where(filter).ToList();
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);

            //_context.Entry(entity).State = EntityState.Modified;
        }
    }
}
