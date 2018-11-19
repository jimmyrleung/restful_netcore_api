using Microsoft.EntityFrameworkCore;
using RestfulCoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestfulCoreAPI.Data
{
    public class MySQLContext: DbContext
    {
        public MySQLContext()
        {
        }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) 
        {
        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Book> Book { get; set; }
    }
}
