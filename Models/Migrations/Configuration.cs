using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
namespace Models.Migrations
{
   
    internal sealed class Configuration : DbMigrationsConfiguration<Models.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Models.DatabaseContext";
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(Models.DatabaseContext databaseContext)
        {
            //  This method will be called after migrating to the latest version.
            if (databaseContext.Users.Count() != 0)
            {
                return;
            }

            try
            {
                DatabaseContextInitializer.Seed(databaseContext);
            }
            catch
            {
            }
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
