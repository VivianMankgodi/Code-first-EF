using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Books.Web.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Genre Category { get; set; }
    }
}