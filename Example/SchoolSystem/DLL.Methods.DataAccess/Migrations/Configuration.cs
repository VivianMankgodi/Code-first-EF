namespace DLL.Methods.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DLL.Methods.DataAccess.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DLL.Methods.DataAccess.SchoolContext context)
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

           // context.Database.Delete();
           // context.Database.Create();
            context.standards.AddOrUpdate(
            b => b.Standardname,
           
                new DataAccess.Standard { Standardname = "grade 9" },
               new DataAccess.Standard { Standardname = "grade 10" },
               new Standard { Standardname = "Grade 11" },
               new Standard { Standardname = "grade 12" },
               new Standard { Standardname = "grade 8"}
               );

            context.genders.AddOrUpdate(
                new DataAccess.Gender { GenderType = "Female"},
                new DataAccess.Gender { GenderType = "Male"}
                );

            context.Teachers.AddOrUpdate(
                new DataAccess.Teacher { TeacherName = "Vivian", Surname ="Tebeila"}
                
                );

          //  context.SaveChanges();
        }
    }
}
