using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppArtists.Models
{
    public class Album
    {
        //this class is one-to- many relationship with Artist
        //one artist can have many albums
        public int AlbumID { get; set; }
        [Required]
        [StringLength(100, MinimumLength =2)]
        public string Title { get; set; }

        //this show that the artuist  will be a foreign key in the Album table
        public virtual Artist artists { get; set; }
        public virtual List<Reviewer> Reviewes { get; set; }
    }
}