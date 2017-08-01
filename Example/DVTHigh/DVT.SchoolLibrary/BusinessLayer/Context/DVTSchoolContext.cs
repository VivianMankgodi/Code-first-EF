using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVT.SchoolLibrary.BusinessLayer.Models;



namespace DVT.SchoolLibrary.BusinessLayer.Context
{
    public class DvtSchoolContext: DbContext
    {
        public DvtSchoolContext(): base("DVTHighSchool")
        {

        }
        public DbSet<Learner> Learners { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Standard> Standards { get; set; }
        public DbSet<Address> Addresses { get; set; }
       public DbSet<AddressType> AddressTypes { get; set; }
        public DbSet<PostalCode> PostalCodes { get; set; }
        public DbSet<Suburb> Suburbs { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Province> Provinces { get; set; }


        //here we want to make Fluent API
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //here i want to make many to many relationship for three classes(Tables)
            modelBuilder.Entity<Standard>().HasKey(pk => new { pk.TeacherId, pk.SubjectId });
            modelBuilder.Entity<Teacher>().HasMany(stnd => stnd.Standard).WithRequired().HasForeignKey(te => te.TeacherId);
            modelBuilder.Entity<Subject>().HasMany(stnd => stnd.Standard).WithRequired().HasForeignKey(sj => sj.SubjectId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
