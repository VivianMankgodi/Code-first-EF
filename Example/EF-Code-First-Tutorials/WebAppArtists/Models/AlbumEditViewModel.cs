using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppArtists.Models
{
    public class AlbumEditViewModel
    {
        public int AlbumId { get; set; }
        public int GenreId { get; set; }
        public int ArtistId { get; set; }
        public string Title { get; set; }
        public string AlbumArtUrl { get; set; }
    }
}