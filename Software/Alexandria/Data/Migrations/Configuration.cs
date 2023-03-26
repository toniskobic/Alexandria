using System.Data.Entity.Migrations;

namespace Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<AlexandriaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AlexandriaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
