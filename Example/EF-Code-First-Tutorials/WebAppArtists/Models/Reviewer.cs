using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppArtists.Models
{
    public class Reviewer
    {
        //this will be Many-To-Many relationship class with Albums
        //Many albums can be reviewd and reviewed can belong to many albums
        public int ReviewerID { get; set; }
        public string Name { get; set; }
        public virtual List<Album> Albums { get; set; }
    }
}