using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtistConsloeApp.Models
{
    class MusicStoredContextInitializer: DropCreateDatabaseAlways<MusicStoredContext>
    {

     
          /*  protected override void Seed(MusicStoredContext context)
            {
                Artist artist = new Artist() { Name = "First Artists" };
                context.Artists.Add(artist);
                artist = new Artist() { Name = "Second Artist" };
                context.Artists.Add(artist);
            artist = new Artist() { Name = "Third Artist" };
            context.Artists.Add(artist);
            context.SaveChanges();

            }*/
        }
}
