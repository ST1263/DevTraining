using CrudRepoAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudRepoAPI.Data
{
    public class databaseContext : DbContext
    {
        public databaseContext(DbContextOptions<databaseContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customer { get; set; }
    }
}
