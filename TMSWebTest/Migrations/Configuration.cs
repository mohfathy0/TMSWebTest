namespace TMSWebTest.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TMSWebTest.Models.Entities>
    {
        public Configuration()
        {
            Database.SetInitializer<Models.Entities>(new CreateDatabaseIfNotExists<Models.Entities>());
       
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TMSWebTest.Models.Entities context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
