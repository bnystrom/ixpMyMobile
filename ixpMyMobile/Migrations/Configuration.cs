namespace ixpMyMobile.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ixpMyMobile.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ixpMyMobile.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ixpMyMobile.Models.ApplicationDbContext context)
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
            context.Items.AddOrUpdate(
                i => i.ItemId,
                new Item { Name = "Broken Bedpans", Description = "Best Bedpans Money Can Buy!", Count = 5, Condition = "Slightly Used", ClientId = 0 }
            );
            
        }
    }
}
