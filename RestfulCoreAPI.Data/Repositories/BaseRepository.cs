using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
            try
            {
                _context.Set<TEntity>().Add(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return entity;
        }
    }
}
