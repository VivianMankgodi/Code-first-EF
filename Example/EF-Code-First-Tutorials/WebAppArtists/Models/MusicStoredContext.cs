using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAppArtists.Models
{
    public class MusicStoredContext: DbContext
    {
        public MusicStoredContext():base("MusicArtist")
        {

        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
    }
}
