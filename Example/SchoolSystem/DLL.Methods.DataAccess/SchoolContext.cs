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
        public SchoolContext():base("name=SchoolContext")
        {

        }

        public DbSet<Student> students { get; set; }
        public DbSet<Standard> standards { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
