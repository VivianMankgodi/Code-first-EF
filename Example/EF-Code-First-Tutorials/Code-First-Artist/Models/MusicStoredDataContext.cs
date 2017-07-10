using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Code_First_Artist.Models
{
    public class MusicStoredDataContext: DbContext
    {
        public MusicStoredDataContext() : base("ArtistMusic")
        {

        }
        public DbSet<Artist>  Aritits{ get; set; }
    }
}