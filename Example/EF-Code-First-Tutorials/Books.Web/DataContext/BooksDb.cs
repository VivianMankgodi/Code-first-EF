using Books.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Books.Web.DataContext
{
    public class BooksDb: DbContext
    {
      
            public BooksDb()
                : base("DefaultConnection")
            {
            }

        public DbSet<Book> Books { get; set; }
    }
} 