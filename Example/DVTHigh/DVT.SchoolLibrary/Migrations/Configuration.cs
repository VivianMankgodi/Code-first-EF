namespace DVT.SchoolLibrary.Migrations
{
    using BusinessLayer.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DVT.SchoolLibrary.BusinessLayer.Context.DvtSchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DVT.SchoolLibrary.BusinessLayer.Context.DvtSchoolContext context)
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


            var province = new List<Province>
            {
                new Province {ProvinceId = 1,ProvinceName = "Gauteng"},
                new Province {ProvinceId = 2, ProvinceName = "Limpopo"},
                new Province {ProvinceId = 3, ProvinceName = "Freestate"},
                new Province {ProvinceId = 4, ProvinceName = "North west"},
                new Province {ProvinceId = 5, ProvinceName = "Cape town"},
                new Province {ProvinceId = 6, ProvinceName = "Kwazulu Natal" }

            };
            province.ForEach(pro => context.Provinces.AddOrUpdate(pr => new
            {
                pr.ProvinceName
            }, pro));

            var postalcode = new List<PostalCode>
            {
                new PostalCode {PostalCodeId = 1,PostalCodeNumber = "2192"},
                new PostalCode {PostalCodeId = 2,PostalCodeNumber = "2190"},
                new PostalCode {PostalCodeId = 3,PostalCodeNumber = "2091"},
                new PostalCode {PostalCodeId = 3,PostalCodeNumber = "0008"}
            };
            postalcode.ForEach(p => context.PostalCodes.AddOrUpdate(pc => pc.PostalCodeNumber, p));


            var city = new List<City>
            {
                new City {CityId= 1,CityName = "Johannesburg", Province = province[0]},
                new City {CityId=2,CityName = "Tshwane", Province = province[0]}
            };
            city.ForEach(c => context.Cities.AddOrUpdate(ci => new { ci.CityName, ci.ProvinceId }, c));


            var suburb = new List<Suburb>
            {
                new Suburb {SuburbId =1,SuburbName = "ABBOTSFORD", PostalCode= postalcode[1], City = city[1]},
                new Suburb {SuburbId =2, SuburbName = "AEROTON", PostalCode = postalcode[2], City = city[1]},
                new Suburb {SuburbId =3,SuburbName = "ALAN-MANOR", PostalCode = postalcode[2], City = city[1]},
                new Suburb {SuburbId =4,SuburbName = "Midrand", PostalCode= postalcode[3], City= city[1] }

            };
            suburb.ForEach(su => context.Suburbs.AddOrUpdate(s => new { s.SuburbName, s.PostalCodeId , s.CityId  }, su));


            var gender = new List<Gender>
            {
                new Gender { GenderId=1,GenderType  = "Male"},
                new Gender {  GenderId=2,GenderType  = "Female" }
            };
            gender.ForEach(ge => context.Genders.AddOrUpdate(g => g.GenderType, ge));

            var userType = new List<UserType >
            {
                new UserType {UserTypeId=1,TypeName = "Teacher" },
                new UserType {UserTypeId=2,TypeName = "Learner" }
            };
            userType.ForEach(usety=> context.UserTypes.AddOrUpdate(ut=> ut.TypeName , usety ));
            context.SaveChanges();

        }
    }
}
