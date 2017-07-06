using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Methods.DataAccess
{
  public   class SchoolInitializer: DropCreateDatabaseAlways<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            Standard satnd = new Standard() { Standardname = "Grade 11" };
            context.standards.Add(satnd);
            context.SaveChanges();
                
              /* new Standard  { Standardname = "grade 12" });

            IList<Standard> defaultStandard = new List<Standard>();
            defaultStandard.Add(new Standard() { Standardname = "Grade 11" });
            defaultStandard.Add(new Standard() { Standardname = "grade 12" });
            foreach (Standard std in defaultStandard )
            {
                context.standards.Add(std);
                context.SaveChanges();
            }*/
           // base.Seed( context);
        }
    }

    /*
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
        }
     */
}
