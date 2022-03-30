using Microsoft.EntityFrameworkCore;
using SuplierProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuplierProject.Data
{
    public class BillingAddressDbContext : DbContext
    {
        public BillingAddressDbContext(DbContextOptions<BillingAddressDbContext> options) : base(options)
        {
        }
        public DbSet<BillingAddress> BillingAddress { get; set; }
    }
}
