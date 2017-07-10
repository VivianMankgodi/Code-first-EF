using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MusicContext: DbContext
    {
        public MusicContext():base("Thandiwe") { }
        public DbSet<Album > Albums { get; set; }
        public DbSet<Artist> Artist { get; set; }
    }
}
