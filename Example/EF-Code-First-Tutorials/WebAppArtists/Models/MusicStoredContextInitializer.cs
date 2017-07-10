using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAppArtists.Models
{
    public class MusicStoredContextInitializer: DropCreateDatabaseAlways<MusicStoredContext>
    {
        protected override void Seed(MusicStoredContext context)
        {
            Artist Theartist = new Artist() { Name = "First Artist" };
            context.Artists.Add(Theartist);
            context.Albums .Add(new Album() { artists = Theartist, Title = "First Album" });
            context.Albums.Add(new Album() { artists = Theartist, Title = "Second Album" });
            Theartist = new Artist() { Name = "Second Artist" };
            context.Artists.Add(Theartist);
            context.Albums.Add(new Album() { artists = context.Artists.Add(new Artist() { Name = "Third Artist" }), Title = "Third Album" });

          //  context.Artists.Add(Theartist);
            context.SaveChanges();

        }
    }
}