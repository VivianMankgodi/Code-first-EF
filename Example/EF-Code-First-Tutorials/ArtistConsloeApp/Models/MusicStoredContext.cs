using ArtistConsloeApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtistConsloeApp
{
    class MusicStoredContext: DbContext
    {
        public MusicStoredContext(): base("MusicArtist")//("Music")
        {

        }
        public DbSet<Artist > Artists { get; set; }
        public DbSet<Solo > Albums { get; set; }

    }
}
