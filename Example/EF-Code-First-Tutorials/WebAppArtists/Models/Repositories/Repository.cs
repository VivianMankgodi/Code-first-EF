using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppArtists.Models.Repositories
{
    public class Repository<T> where T : class 
    {
        //in this class we just created method that we want to use them in different classes that is why we just specify the <T> so that it will stand for any Datatype or className we can say this class is the Base class Interface tha we can inherite it on the other classes
        private MusicStoredContext context = null;
        protected DbSet<T> DbSets { get; set; }
        public Repository()
        {
            context = new MusicStoredContext();
            DbSets = context.Set<T>();
        }

        public Repository(MusicStoredContext context2)
        {
            this.context = context2;
        }

        //this is the method for getting all the list 
        public List<T> GetAll()
        { return DbSets.ToList();
        }

        //this is the method  we get a data by ID PK
        public T Get(int id)
        {
            return DbSets.Find(id);

        }

        //this is the method  add/insert information 
         public void Adds(T entity)
         {
             DbSets.Add(entity);
         }

        //this is the method  we save the data that was inserted
        public void SaveChange()
        {
            context.SaveChanges();
        }
    }
}