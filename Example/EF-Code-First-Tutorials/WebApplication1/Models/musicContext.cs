using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class musicContext: DbContext 
    {
        public musicContext():base("music")
        {
            Database.Log = s => Debug.WriteLine(s);
        }
        public DbSet<Album > Albums { get; set; }
        public DbSet<Artist> artist { get; set; }
    }
}