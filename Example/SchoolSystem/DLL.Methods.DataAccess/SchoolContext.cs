using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Methods.DataAccess
{
 public    class SchoolContext: DbContext
    {
        public SchoolContext():base("SchoolDB")
        {

            //Database.SetInitializer<SchoolContext>(new CreateDatabaseIfNotExists<SchoolContext >());
            //    Database.SetInitializer<SchoolContext>(new DropCreateDatabaseAlways<SchoolContext>());
            Database.SetInitializer(new SchoolInitializer());
        }

        public DbSet<Student> students { get; set; }
        public DbSet<Standard> standards { get; set; }
        public DbSet<Course> Courses { get; set; }

       /* protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //i can use many to many relationship in here
            modelBuilder.Entity<Student>().HasMany<Course>(s => s.Courses).WithMany(c => c.Students).Map(cs => { cs.MapLeftKey("StudentrefId"); cs.MapRightKey("CourseRedId"); cs.ToTable("StudentCourse"); });
        }*/
    }
}
