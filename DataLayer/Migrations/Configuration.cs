namespace DataLayer.Migrations
{
    using DataLayer.DBModels;
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
            var firstDepartment = new Department { id = 1, DepartmentName = "IT" };
            context.Departman.AddOrUpdate(firstDepartment);
            var person = new Personel { id = 1, Name = "Muhammed", Surname = "Zayif" ,Department= firstDepartment };
            context.Personel.AddOrUpdate(person);

            context.Users.AddOrUpdate(new User { id = 1, Name = "Muhammed", Surename = "Zayif", UserName = "mz", Password = "123", Personel = person });

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
