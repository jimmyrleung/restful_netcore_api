using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestfulCoreAPI.Data.Repositories
{
    // TEntity must be a class
    public class BaseRepository<TEntity> where TEntity : class
    {
        private MySQLContext _context;
        private DbSet<TEntity> _dbSet;
        public BaseRepository(MySQLContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public TEntity Create(TEntity entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
            return entity;
        }

        public TEntity GetbyId(int id)
        {
            return _dbSet.Find(id);
        }

        public IList<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Delete(int id)
        {
            TEntity entityToDelete = GetbyId(id);
            _dbSet.Remove(entityToDelete);
            _context.SaveChanges();
        }
    }
}
