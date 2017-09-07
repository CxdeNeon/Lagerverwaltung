using System.Collections.Generic;

namespace Lagerverwaltung.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Lagerverwaltung.DbContextLager>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Lagerverwaltung.DbContextLager context)
        {
            Category kaeseCat = new Category("K�seumh�ngeband");
            Produkt kaese = new Produkt("K�se", 1, 1, "Lecker K�se");

            using (var db = DbContextLager.Create())
            {
                db.Categories.Add(kaeseCat);
                db.SaveChanges();
            }

            using (var db = DbContextLager.Create())
            {
                var categories = db.Categories;
                foreach (var category in categories)
                {
                    kaese.CategoryId = category.CategoryId;

                }

                db.Products.AddOrUpdate(kaese);
                db.SaveChanges();
            }
        }
    }
}
