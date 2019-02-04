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
    }
}