using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAppArtist
{
    public class Artist
    {
        public int ArtistID { get; set; }

        //adding Annotations 
       [Required]
        [StringLength(100, MinimumLength =2)]
        public string Name { get; set; }
        public string Bio { get; set; }
    }
}
