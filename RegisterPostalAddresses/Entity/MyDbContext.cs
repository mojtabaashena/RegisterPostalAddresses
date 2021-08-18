using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RegisterPostalAddresses.Models;

namespace RegisterPostalAddresses.Entity
{
    public class MyDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }


    }
}
