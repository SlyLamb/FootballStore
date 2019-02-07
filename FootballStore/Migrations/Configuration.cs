namespace FootballStore.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;
    using System.Collections.Generic;
    using System.Web;
    using Microsoft.AspNet.Identity.Owin;
    using Microsoft.AspNet.Identity;

    internal sealed class Configuration : DbMigrationsConfiguration<FootballStore.OSDB.StoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "FootballStore.OSDB.StoreContext";
        }

        protected override void Seed(FootballStore.OSDB.StoreContext context)
        {
            //  This method will be called after migrating to the latest version.
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            // Seed categories to database
            var categories = new List<Category>
            {
                new Category { Name = "Balls" },
                new Category { Name = "Boots" },
                new Category { Name = "Goals" },
                new Category { Name = "Shin pads" },
                new Category { Name = "Shirts" },
                new Category { Name = "Shorts" }
            };
            categories.ForEach(c => context.Categories.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();
            // Seed brands to database
            var brands = new List<Brand>
            {
                new Brand { Name = "Nike" },
                new Brand { Name = "Adidas" },
                new Brand { Name = "Under Armour" },
                new Brand { Name = "Umbro" },
                new Brand { Name = "Other" }
            };
            brands.ForEach(c => context.Brands.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();
            // Seed products to database
            var products = new List<Product>
            {
                new Product { Name = "EPP", Description = "This ball's construction ensures soft touch and high durability.", Price = 22.50M, CategoryID = categories.Single(c => c.Name == "Balls").ID, BrandID = brands.Single(b => b.Name == "Adidas").ID },
                new Product { Name = "Messi Capitano", Description = "100% Thermoplastic Polyurethane.", Price = 31, CategoryID = categories.Single(c => c.Name == "Balls").ID, BrandID = brands.Single(b => b.Name == "Adidas").ID },
                new Product { Name = "Starlancer V", Description = "Features Butyl Bladder for best air retention.", Price = 21.49M, CategoryID = categories.Single(c => c.Name == "Balls").ID, BrandID = brands.Single(b => b.Name == "Adidas").ID },
                new Product { Name = "Team Top", Description = "Created for training sessions and matches, this football has a seamless surface for a better touch and lower water uptake.", Price = 42.50M, CategoryID = categories.Single(c => c.Name == "Balls").ID, BrandID = brands.Single(b => b.Name == "Adidas").ID },
                new Product { Name = "Phantom Venom", Description = "Features high-contrast graphics inspired by the Phantom Venom boots.", Price = 23.45M, CategoryID = categories.Single(c => c.Name == "Balls").ID, BrandID = brands.Single(b => b.Name == "Nike").ID },
                new Product { Name = "React", Description = "Delivers excellent touch and high visibility on the field.", Price = 18.50M, CategoryID = categories.Single(c => c.Name == "Balls").ID, BrandID = brands.Single(b => b.Name == "Nike").ID },
                new Product { Name = "Skills", Description = "Ideal for practicing and developing your on-field footwork.", Price = 15.50M, CategoryID = categories.Single(c => c.Name == "Balls").ID, BrandID = brands.Single(b => b.Name == "Nike").ID },
                new Product { Name = "Strike", Description = "Durable design with 12 panels for true and accurate ball flight.", Price = 30, CategoryID = categories.Single(c => c.Name == "Balls").ID, BrandID = brands.Single(b => b.Name == "Nike").ID },
                new Product { Name = "Neo Endurance", Description = "Hand stitched, match weight and for use on grass.", Price = 26.99M, CategoryID = categories.Single(c => c.Name == "Balls").ID, BrandID = brands.Single(b => b.Name == "Umbro").ID },
                new Product { Name = "Neo Team", Description = "Durable, machine stitched TPU.", Price = 21, CategoryID = categories.Single(c => c.Name == "Balls").ID, BrandID = brands.Single(b => b.Name == "Umbro").ID },
                new Product { Name = "Neo Trainer", Description = "30 panel machine stitched ball.", Price = 19.45M, CategoryID = categories.Single(c => c.Name == "Balls").ID, BrandID = brands.Single(b => b.Name == "Umbro").ID },
                new Product { Name = "Neo", Description = "Original from Neo range.", Price = 16.98M, CategoryID = categories.Single(c => c.Name == "Balls").ID, BrandID = brands.Single(b => b.Name == "Umbro").ID },
                new Product { Name = "Copa", Description = "Mid-cut leather upper for a soft touch. Breathable, waterproof lining for dry and comfortable feet.", Price = 550, CategoryID = categories.Single(c => c.Name == "Boots").ID, BrandID = brands.Single(b => b.Name == "Adidas").ID },
                new Product { Name = "Nemeziz", Description = "Firm groung boots. Unique bandage construction that provides complete flexibility.", Price = 440, CategoryID = categories.Single(c => c.Name == "Boots").ID, BrandID = brands.Single(b => b.Name == "Adidas").ID },
                new Product { Name = "Predator", Description = "Built for precision on soft ground, these boots have a supportive knit textile upper.", Price = 320, CategoryID = categories.Single(c => c.Name == "Boots").ID, BrandID = brands.Single(b => b.Name == "Adidas").ID },
                new Product { Name = "X", Description = "Firm ground boots. Sculpted for speed, a low-cut collar, moulded heel and skin-tight fit lock your foot in, eliminating the need for laces.", Price = 240, CategoryID = categories.Single(c => c.Name == "Boots").ID, BrandID = brands.Single(b => b.Name == "Adidas").ID },
                new Product { Name = "Phantom Venom Elite", Description = "Engineered for powerful, precise strikes. Ridges on the instep help create spin to control the flight of the ball.", Price = 330, CategoryID = categories.Single(c => c.Name == "Boots").ID, BrandID = brands.Single(b => b.Name == "Nike").ID },
                new Product { Name = "Phantom Vision Academy Dynamic", Description = "Textured material wraps your foot to give you precision and control, while a cover over your laces gives you a bigger strike zone.", Price = 220, CategoryID = categories.Single(c => c.Name == "Boots").ID, BrandID = brands.Single(b => b.Name == "Nike").ID },
                new Product { Name = "Mercurial Superfly", Description = "Provides secure comfort and a specialised outsole that promotes acceleration and quick directional changes on multiple kinds of surfaces, like natural and artificial grass.", Price = 120, CategoryID = categories.Single(c => c.Name == "Boots").ID, BrandID = brands.Single(b => b.Name == "Nike").ID },
                new Product { Name = "Mercurial Vapor", Description = "Wraps your foot for a perfect fit and exceptional ball touch. The outsole plate resists mud, providing consistent traction on the pitch.", Price = 320, CategoryID = categories.Single(c => c.Name == "Boots").ID, BrandID = brands.Single(b => b.Name == "Nike").ID },
                new Product { Name = "Clutchfit", Description = "Add more power and control to your game.", Price = 300, CategoryID = categories.Single(c => c.Name == "Boots").ID, BrandID = brands.Single(b => b.Name == "Under Armour").ID },
                new Product { Name = "Force", Description = "Features a new pattern design on its upper, the boots provide a softer feel for a better touch on the ball.", Price = 310, CategoryID = categories.Single(c => c.Name == "Boots").ID, BrandID = brands.Single(b => b.Name == "Under Armour").ID },
                new Product { Name = "Magnetico", Description = "Features ClutchFit 2.0 technology for superior fit and feel on the ball.", Price = 220, CategoryID = categories.Single(c => c.Name == "Boots").ID, BrandID = brands.Single(b => b.Name == "Under Armour").ID },
                new Product { Name = "Spotlight", Description = "Designed for offensive players. Features a lightweight, synthetic upper.", Price = 300, CategoryID = categories.Single(c => c.Name == "Boots").ID, BrandID = brands.Single(b => b.Name == "Under Armour").ID },
                new Product { Name = "Accuro", Description = "Features brand new 'pro-stance' outsole designed to give you balance and stability.", Price = 285, CategoryID = categories.Single(c => c.Name == "Boots").ID, BrandID = brands.Single(b => b.Name == "Umbro").ID },
                new Product { Name = "Medusae", Description = "Features Premium K-Leather, which gives a magic touch, and speed outsole for rapid twists and turns.", Price = 200, CategoryID = categories.Single(c => c.Name == "Boots").ID, BrandID = brands.Single(b => b.Name == "Umbro").ID },
                new Product { Name = "Speciali Eternal", Description = "A classic returns! Reborn and ready for the modern game, the Speciali Eternal is inspired by the greatest boot in Umbro's history.", Price = 190, CategoryID = categories.Single(c => c.Name == "Boots").ID, BrandID = brands.Single(b => b.Name == "Umbro").ID },
                new Product { Name = "Velocita", Description = "Features neoprene mesh in the rearfoot and airmesh in the forefoot, which provide a responsive fit and comfort.", Price = 185, CategoryID = categories.Single(c => c.Name == "Boots").ID, BrandID = brands.Single(b => b.Name == "Umbro").ID },
                new Product { Name = "Small", Description = "Portable synthetic goals.", Price = 19.99M, CategoryID = categories.Single(c => c.Name == "Goals").ID, BrandID = brands.Single(b => b.Name == "Other").ID },
                new Product { Name = "Medium", Description = "Portable medium-size goals.", Price = 35, CategoryID = categories.Single(c => c.Name == "Goals").ID, BrandID = brands.Single(b => b.Name == "Other").ID },
                new Product { Name = "Large", Description = "Large steel goals.", Price = 50, CategoryID = categories.Single(c => c.Name == "Goals").ID, BrandID = brands.Single(b => b.Name == "Other").ID },
                new Product { Name = "X Pro", Description = "Features soft synthetic lining and EVA backing for high comfort and durable cushioning.", Price = 34.50M, CategoryID = categories.Single(c => c.Name == "Shin pads").ID, BrandID = brands.Single(b => b.Name == "Adidas").ID },
                new Product { Name = "J CE", Description = "Features a durable, lightweight shell for excellent impact protection on the pitch.", Price = 15, CategoryID = categories.Single(c => c.Name == "Shin pads").ID, BrandID = brands.Single(b => b.Name == "Nike").ID },
                new Product { Name = "Neo Shield Slip", Description = "Delivers unrivalled protection yet remain supremely comfortable and lightweight.", Price = 18, CategoryID = categories.Single(c => c.Name == "Shin pads").ID, BrandID = brands.Single(b => b.Name == "Umbro").ID },
                new Product { Name = "Juventus", Description = "Official uniform.", Price = 160, CategoryID = categories.Single(c => c.Name == "Shirts").ID, BrandID = brands.Single(b => b.Name == "Adidas").ID },
                new Product { Name = "Manchester United", Description = "Official uniform.", Price = 125, CategoryID = categories.Single(c => c.Name == "Shirts").ID, BrandID = brands.Single(b => b.Name == "Adidas").ID },
                new Product { Name = "Real Madrid", Description = "Official uniform.", Price = 132, CategoryID = categories.Single(c => c.Name == "Shirts").ID, BrandID = brands.Single(b => b.Name == "Adidas").ID },
                new Product { Name = "Spain", Description = "Official uniform.", Price = 110, CategoryID = categories.Single(c => c.Name == "Shirts").ID, BrandID = brands.Single(b => b.Name == "Adidas").ID },
                new Product { Name = "Barcelona", Description = "Official uniform.", Price = 130, CategoryID = categories.Single(c => c.Name == "Shirts").ID, BrandID = brands.Single(b => b.Name == "Nike").ID },
                new Product { Name = "Chelsea", Description = "Official uniform.", Price = 125, CategoryID = categories.Single(c => c.Name == "Shirts").ID, BrandID = brands.Single(b => b.Name == "Nike").ID },
                new Product { Name = "Portugal", Description = "Official uniform.", Price = 105, CategoryID = categories.Single(c => c.Name == "Shirts").ID, BrandID = brands.Single(b => b.Name == "Nike").ID },
                new Product { Name = "PSG", Description = "Official uniform.", Price = 130, CategoryID = categories.Single(c => c.Name == "Shirts").ID, BrandID = brands.Single(b => b.Name == "Nike").ID },
                new Product { Name = "Fixture", Description = "Official uniform.", Price = 80, CategoryID = categories.Single(c => c.Name == "Shirts").ID, BrandID = brands.Single(b => b.Name == "Under Armour").ID },
                new Product { Name = "Golazo", Description = "Official uniform.", Price = 75, CategoryID = categories.Single(c => c.Name == "Shirts").ID, BrandID = brands.Single(b => b.Name == "Under Armour").ID },
                new Product { Name = "Maquina", Description = "Official uniform.", Price = 70, CategoryID = categories.Single(c => c.Name == "Shirts").ID, BrandID = brands.Single(b => b.Name == "Under Armour").ID },
                new Product { Name = "Southampton", Description = "Official uniform.", Price = 89.99M, CategoryID = categories.Single(c => c.Name == "Shirts").ID, BrandID = brands.Single(b => b.Name == "Under Armour").ID },
                new Product { Name = "Gremio", Description = "Official uniform.", Price = 100, CategoryID = categories.Single(c => c.Name == "Shirts").ID, BrandID = brands.Single(b => b.Name == "Umbro").ID },
                new Product { Name = "Schalke", Description = "Official uniform.", Price = 95, CategoryID = categories.Single(c => c.Name == "Shirts").ID, BrandID = brands.Single(b => b.Name == "Umbro").ID },
                new Product { Name = "Werder Bremen", Description = "Official uniform.", Price = 98, CategoryID = categories.Single(c => c.Name == "Shirts").ID, BrandID = brands.Single(b => b.Name == "Umbro").ID },
                new Product { Name = "West Ham United", Description = "Official uniform.", Price = 105, CategoryID = categories.Single(c => c.Name == "Shirts").ID, BrandID = brands.Single(b => b.Name == "Umbro").ID },
                new Product { Name = "Black", Description = "Football shorts.", Price = 32.50M, CategoryID = categories.Single(c => c.Name == "Shorts").ID, BrandID = brands.Single(b => b.Name == "Adidas").ID },
                new Product { Name = "Blue", Description = "Football shorts.", Price = 30, CategoryID = categories.Single(c => c.Name == "Shorts").ID, BrandID = brands.Single(b => b.Name == "Adidas").ID },
                new Product { Name = "Gray", Description = "Football shorts.", Price = 35, CategoryID = categories.Single(c => c.Name == "Shorts").ID, BrandID = brands.Single(b => b.Name == "Adidas").ID },
                new Product { Name = "Real Madrid", Description = "Official uniform.", Price = 37.50M, CategoryID = categories.Single(c => c.Name == "Shorts").ID, BrandID = brands.Single(b => b.Name == "Adidas").ID },
                new Product { Name = "Blue", Description = "Football shorts.", Price = 38, CategoryID = categories.Single(c => c.Name == "Shorts").ID, BrandID = brands.Single(b => b.Name == "Nike").ID },
                new Product { Name = "Green", Description = "Football shorts.", Price = 38, CategoryID = categories.Single(c => c.Name == "Shorts").ID, BrandID = brands.Single(b => b.Name == "Nike").ID },
                new Product { Name = "Orange", Description = "Football shorts.", Price = 42, CategoryID = categories.Single(c => c.Name == "Shorts").ID, BrandID = brands.Single(b => b.Name == "Nike").ID },
                new Product { Name = "White", Description = "Football shorts.", Price = 42, CategoryID = categories.Single(c => c.Name == "Shorts").ID, BrandID = brands.Single(b => b.Name == "Nike").ID },
                new Product { Name = "Black", Description = "Football shorts.", Price = 33.99M, CategoryID = categories.Single(c => c.Name == "Shorts").ID, BrandID = brands.Single(b => b.Name == "Under Armour").ID },
                new Product { Name = "Gold", Description = "Football shorts.", Price = 35, CategoryID = categories.Single(c => c.Name == "Shorts").ID, BrandID = brands.Single(b => b.Name == "Under Armour").ID },
                new Product { Name = "Gray", Description = "Football shorts.", Price = 32.75M, CategoryID = categories.Single(c => c.Name == "Shorts").ID, BrandID = brands.Single(b => b.Name == "Under Armour").ID },
                new Product { Name = "Red", Description = "Football shorts.", Price = 34, CategoryID = categories.Single(c => c.Name == "Shorts").ID, BrandID = brands.Single(b => b.Name == "Under Armour").ID },
                new Product { Name = "Blackberry", Description = "Football shorts.", Price = 25, CategoryID = categories.Single(c => c.Name == "Shorts").ID, BrandID = brands.Single(b => b.Name == "Umbro").ID },
                new Product { Name = "Green", Description = "Football shorts.", Price = 23.50M, CategoryID = categories.Single(c => c.Name == "Shorts").ID, BrandID = brands.Single(b => b.Name == "Umbro").ID },
                new Product { Name = "Red", Description = "Football shorts.", Price = 27, CategoryID = categories.Single(c => c.Name == "Shorts").ID, BrandID = brands.Single(b => b.Name == "Umbro").ID },
                new Product { Name = "Yellow", Description = "Football shorts.", Price = 28.99M, CategoryID = categories.Single(c => c.Name == "Shorts").ID, BrandID = brands.Single(b => b.Name == "Umbro").ID }
            };
            //products.ForEach(c => context.Products.AddOrUpdate(p => p.Name, c));
            //context.SaveChanges();
            foreach (Product p in products)
            {
                var productInDatabase = context.Products.Where(
                    pro => pro.Name == p.Name &&
                    pro.CategoryID == p.CategoryID &&
                    pro.BrandID == p.BrandID).SingleOrDefault();
                if (productInDatabase == null)
                {
                    context.Products.Add(p);
                }
            }
            context.SaveChanges();
        }
    }
}
