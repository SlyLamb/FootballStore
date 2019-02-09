using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FootballStore.Models;
using System.Data.Entity;

namespace FootballStore.OSDB
{
    public class StoreContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<ProductImage> ProductImages { get; set; }

        public DbSet<ProductImageMapping> ProductImageMappings { get; set; }

        public DbSet<BasketLine> BasketLines { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderLine> OrderLines { get; set; }

    }
}