using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First
{
    class Program
    {
        static void Main(string[] args)
        {
          //  PerformDatabaseOperations();
            using (var db = new PersonDbContext())
            {
                var person = new Person
                {
                    FirstName = "1Nadege",
                    LastName = "Deroussen",
                    BirthDate = DateTime.Now
                };

                db.Persons.Add(person);
                db.SaveChanges();
            }
          //  Console.Write("Person saved !");
           // Console.ReadLine();
        }
        /*public static void PerformDatabaseOperations()
        {
            using (var db = new PersonDbContext())
            {
                var person = new Person
                {
                    FirstName = "Nadege",
                    LastName = "Deroussen",
                    BirthDate = DateTime.Now
                };

                db.Persons.Add(person);
                db.SaveChanges();
            }
        }*/
    }
}
