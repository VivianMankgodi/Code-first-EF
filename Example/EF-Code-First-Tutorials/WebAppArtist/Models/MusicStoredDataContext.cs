using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace WebAppArtist.Models
{
    public class MusicStoredDataContext: DbContext
    {
        public MusicStoredDataContext():base("MusicArtist")
        {

        }

        public DbSet<Artist> Artists { get; set; }
    }
}