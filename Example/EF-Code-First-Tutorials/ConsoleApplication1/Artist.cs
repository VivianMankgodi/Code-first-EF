using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Artist
    {
        public int ArtistID { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
