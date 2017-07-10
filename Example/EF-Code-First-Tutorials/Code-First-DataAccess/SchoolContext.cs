using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Code_First_DataAccess
{
    class SchoolContext: DbContext
    {

        // DbSet is a collection of entity classes(aka entity set), so we have given property name as plural of entity name like Students and Standards

        //we must always havethe constructor method as part of BASE method
        public SchoolContext() : base()
        {

        }

        //creating classes(Tables) DbSet because they must be part of DbContext class
        public DbSet<Student> Studentds { get; set; }
        public DbSet<Standard> Standards { get; set; }
    }
}
