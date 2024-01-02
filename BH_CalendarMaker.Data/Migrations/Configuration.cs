namespace BH_CalendarMaker.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BH_CalendarMaker.Data.BH_CalendarMakerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "BH_CalendarMaker.Data.BH_CalendarMakerContext";
        }

        protected override void Seed(BH_CalendarMaker.Data.BH_CalendarMakerContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
