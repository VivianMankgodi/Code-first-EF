using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess_Code_First
{
    class SchoolContext: DbContext
    {
        //teacher class it is DERVED Class and the context class only include Base Classes as DbSet
        // DbSet is a collection of entity classes(aka entity set), so we have given property name as plural of entity name like Students and Standards

        //we must always havethe constructor method as part of BASE method
        //inside the base() method we can specify the name of the database we want our database to have
        public SchoolContext(): base("name=SchoolDBConnecionString")//this is the name of the connection string 
        {

        }

        //creating classes(Tables) DbSet because they must be part of DbContext class
        //even if in here we don't have Teacher class DbSet but it will be there in the database becuase of Student Class(Table) becuase we included it as a Foriegn key 
        public DbSet<Student> Studentds { get; set; }
        public DbSet<Standard> Standards { get; set; }
    }
}
