using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtistConsloeApp.Models.Repositories
{
    class Repository<T> where T: class
    {
        private MusicStoredContext dbcontext = new MusicStoredContext();

        public DbSet<T> SetDb { get; set; }

        public Repository()
        {
            SetDb = dbcontext.Set<T>();         
        }


        public  List<T> GetAll()
        {
            return SetDb.ToList();
        }

    }
}
