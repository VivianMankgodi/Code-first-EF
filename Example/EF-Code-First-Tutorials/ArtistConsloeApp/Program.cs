using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtistConsloeApp.Models.Repositories;

namespace ArtistConsloeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArtistRepository repository = new ArtistRepository();

            using (var context = new MusicStoredContext())
            {
                var count = context.Artists.Count();
                  
                Console.WriteLine("Hello we have " + count +  " rows of data");

                

                
            }

            string name = "";
            ////Console.WriteLine(repository.GetByName(name));
            //Artist art = new Artist();
            //MusicStoredContext k = new ArtistConsloeApp.MusicStoredContext();
            //var query = from a in k.Artists  select a;
            //foreach (var item in query )
            //{
            //    Console.WriteLine(item.Name );
            //}

           // repository.Listing();
            repository.GetAllNames();
         //   List();

        // repository.Listing();//  repository.GetsAll());



            Console.ReadKey();

        }

        static void List()
        {
            //   Artist art = new Artist();
            MusicStoredContext k = new ArtistConsloeApp.MusicStoredContext();
            var query = from a in k.Artists select a;
            foreach (var item in query)
            {
                Console.WriteLine(item.ArtistID + " " + item.Name);
            }
        }
    }
}
