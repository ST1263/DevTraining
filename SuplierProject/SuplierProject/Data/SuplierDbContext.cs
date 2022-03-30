using Microsoft.EntityFrameworkCore;
using SuplierProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuplierProject.Data
{
    public class SuplierDbContext : DbContext
    {
        public SuplierDbContext(DbContextOptions<SuplierDbContext> options) : base(options)
        {
        }
        public DbSet<Suplier> Suplier { get; set; }
    }
}
