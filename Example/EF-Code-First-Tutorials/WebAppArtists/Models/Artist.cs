using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppArtists.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }

        //adding Annotations 
       [Required]
       [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }
        public virtual List<Album> albums { get; set; }
        public virtual ArtistDetails artistDetails { get; set; }

    }
}