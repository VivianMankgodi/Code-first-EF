using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVT.SchoolLibrary.BusinessLayer.Context;

namespace DVT.SchoolLibrary.DataAccessLayer.Repositories
{
  public   class Repository<T> where T: class 
    {
     private    DvtSchoolContext context = new DvtSchoolContext();
        protected  DbSet<T> DbSets { get; set; }
   public  Repository()
   {
       DbSets = context.Set<T>( );
   }

        public List<T> GetAll()
        {
       return DbSets.ToList();
        }

        public T FindById(int entity)
        {
           return  DbSets.Find(entity );
        }

        public void Inserting(T entities)
        {
            DbSets.Add(entities );
           
        }

        public void SaveChange()
        {
            context.SaveChanges();
        }
    }
}
