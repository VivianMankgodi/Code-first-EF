using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Web.Books.Models;

namespace Web.Books.DataContext
{
    public class BookDb: DbContext 
    {
        public BookDb()
            : base("DefaultConnection")
        {
        }
        public DbSet<Book> Books { get; set; }
    }
}