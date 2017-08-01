using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVT.SchoolLibrary.Context;

namespace DVT.SchoolLibrary.Repositories
{
  public   class Repository<T> where T : class
    {
        //calling the Context class as a private in here
        private DVTSchoolContext context = new DVTSchoolContext();
        //here we want to use dbSet 
        protected DbSet<T> dbSets { get; set; }

        //here we want to use the constructor to show that the protected DbSet is are from our contet class
        public Repository()
        {
            dbSets = context.Set<T>();
        }

        //here we want to use to Get everthing from the specific  tables
        public List<T> GetAll()
        {
           

            return dbSets.ToList();
        }

       

    }
}
