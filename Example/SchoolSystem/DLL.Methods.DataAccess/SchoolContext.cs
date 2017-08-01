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
  //   Database.SetInitializer<SchoolContext>(new DropCreateDatabaseAlways<SchoolContext>());
          //  Database.SetInitializer<SchoolContext>(new DropCreateDatabaseIfModelChanges<SchoolContext>());
            //Database.SetInitializer(new SchoolInitializer());
        }

        public virtual DbSet<Student> students { get; set; }
        public virtual DbSet<Standard> standards { get; set; }
        public virtual  DbSet<Course> Courses { get; set; }
        public virtual  DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Gender> genders { get; set; }
                                           /* protected override void OnModelCreating(DbModelBuilder modelBuilder)
                                            {
                                                base.OnModelCreating(modelBuilder);
                                                //i can use many to many relationship in here
                                                modelBuilder.Entity<Student>().HasMany<Course>(s => s.Courses).WithMany(c => c.Students).Map(cs => { cs.MapLeftKey("StudentrefId"); cs.MapRightKey("CourseRedId"); cs.ToTable("StudentCourse"); });
                                            }*/
    }
}
