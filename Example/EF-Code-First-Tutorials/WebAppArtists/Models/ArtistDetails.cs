using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppArtists.Models
{
    public class ArtistDetails
    {
        //this class will be one-to-one relationship with Artist class
        //one artist can have one ArtistDetails

            [Key()]//we specify this with Key DataAnnotation becuase our PK will be different name as out class
            [ForeignKey("Artist")]//this show that ArtistId is the FK and even PK  in ArtistDetails Table
        public int ArtistID { get; set; }
        public string Bio { get; set; }
        public virtual  Artist Artist { get; set; }
    }
}