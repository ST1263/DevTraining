using CrudRepository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudRepository.Data;


namespace CrudRepository.Data
{
    public class databaseContext: DbContext
    {
        public databaseContext(DbContextOptions<databaseContext> options): base(options)
        {

        }
        public DbSet<Book>Book{ get; set; }
    }

    
}
