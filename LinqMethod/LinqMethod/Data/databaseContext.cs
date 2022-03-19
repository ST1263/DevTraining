using LinqMethod.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqMethod.Data
{
    public class databaseContext:DbContext
    {
        public databaseContext(DbContextOptions<databaseContext> options) : base(options)
        {
        }
        public DbSet<Emp> Emp { get; set; }
    }
}
