using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtistConsloeApp
{
    class Artist
    {
        public int ArtistID { get; set; }

        //adding Annotations 
       [Required]
       [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }
        //public string Bio { get; set; }
    }
}
