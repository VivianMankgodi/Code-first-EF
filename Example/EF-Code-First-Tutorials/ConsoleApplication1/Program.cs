using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MusicContext())
            {
                //if we just call this like it it will select all data
               // var albums = context.Albums;

                //here we are counting them 
                var count = context.Albums.Count();
                Console.WriteLine(count);

                //this show the connection string
                Console.WriteLine(context.Database.Connection.ConnectionString);
                Console.ReadKey();
            }

           
        }

    }

}
