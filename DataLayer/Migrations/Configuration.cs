namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataLayer.DataModelStok>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataLayer.DataModelStok context)
        {
            context.Personel.AddOrUpdate(new DBModels.Personel { id = 1, Ad = "Muhammed", Soyad = "Zayif" });

            context.Users.AddOrUpdate(new DBModels.User { id = 1, Name = "Muhammed", Surename = "Zayif", UserName = "mz", Password = "123" });

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
