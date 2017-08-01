namespace DVT.SchoolLibrary.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration// : DbMigrationsConfiguration<DVT.SchoolLibrary.Context.DVTSchoolContext>
    {
        public Configuration()
        {
            //AutomaticMigrationsEnabled = false;
        }

       // protected override void Seed(DVT.SchoolLibrary.Context.DVTSchoolContext context)
      //  {
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
            //context.Database.Delete();
            //context.Database.Create();
            //context.Genders.AddOrUpdate(
            //    new Gender {Type ="Male"},
            //     new Gender() { Type = "Female"}
            //    );

            //context.Cities.AddOrUpdate(

            //    new City() { CityName = "Pretoria", ProvinceID = 1 },
            //    new City() { CityName = "Johannesburg", ProvinceID = 1 },
            //    new City { CityName = "Roodebord", ProvinceID = 1 });

            //context.PostalCodes.AddOrUpdate(
            //    new PostalCode { PostalCodeNumber = "8000"},
            //    new PostalCode { PostalCodeNumber = "9000"},
            //    new PostalCode { PostalCodeNumber = "1000"},
            //    new PostalCode { PostalCodeNumber="0001"}
            //    );

            //context.Provinces.AddOrUpdate(
                
            //    new Province {ProvinceName = "Gauteng" });

            //context.SaveChanges();
      //  }
    }
}
