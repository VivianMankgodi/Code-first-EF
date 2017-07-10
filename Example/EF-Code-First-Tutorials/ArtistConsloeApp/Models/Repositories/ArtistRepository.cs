using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtistConsloeApp.Models.Repositories
{
    class ArtistRepository: Repository<Artist >
    {

        
            public List<Artist> GetByName(string Name)
            {
                //here we want to select all the artist that has name
                return SetDb.Where(a => a.Name.Contains(Name)).ToList();
            }
        public List<Artist > GetsAll()
        {
            return SetDb.ToList();
        }

        MusicStoredContext k = new ArtistConsloeApp.MusicStoredContext();
        public List<Artist> GetAllNames()
        {
            var query = from a in k.Artists select a;

            return query.ToList();
        }
       public void Listing()
        {
         //   Artist art = new Artist();
           
            var query = from a in k.Artists select a;
            foreach (var item in query)
            {
                Console.WriteLine(item.ArtistID+" "+ item.Name );
            }
        }

        }
}
