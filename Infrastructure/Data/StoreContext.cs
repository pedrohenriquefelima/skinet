using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        //the DbContext methods help query database
        //StoreContext will be provided with some options which will then be passed to the base class - DbContext
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        //StoreContext will allow to access the 'products' and use the methods defined inside DbContext
        public DbSet<Product> Products { get; set; }
    }
}