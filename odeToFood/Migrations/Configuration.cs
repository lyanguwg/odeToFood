namespace odeToFood.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<odeToFood.Models.OdetoFoodDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "odeToFood.Models.OdetoFoodDb";
        }

        protected override void Seed(odeToFood.Models.OdetoFoodDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Restarants.AddOrUpdate(r => r.Name,
                new Models.Restaurant { Name = "R1", City = "Austin", Country = "US" },
                new Models.Restaurant { Name = "R2", City = "Atlanta", Country = "US" },
                new Models.Restaurant
                {
                    Name = "R3",
                    City = "Dallas",
                    Country = "US",
                    Reviews = new List<Models.Review> {
                        new Models.Review { Rating = 10, Body = "great one" ,ReviewerName = "Scott"}



                    }
                });

        }
    }
}
