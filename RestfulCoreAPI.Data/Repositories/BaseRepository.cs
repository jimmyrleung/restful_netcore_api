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
        MySQLContext _context;
        public BaseRepository(MySQLContext context)
        {
            _context = context;
        }

        public TEntity Create(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();
            return entity;
        }

        public TEntity GetbyId(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public IList<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public void Delete(int id)
        {
            TEntity entityToDelete = GetbyId(id);
            _context.Set<TEntity>().Remove(entityToDelete);
            _context.SaveChanges();
        }
    }
}
