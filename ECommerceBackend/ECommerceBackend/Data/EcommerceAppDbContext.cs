using ECommerceBackend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceBackend.Data
{
    public class EcommerceAppDbContext: DbContext
    {
        public EcommerceAppDbContext(DbContextOptions<EcommerceAppDbContext> options) : base(options) { }

        

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }



    }
}
