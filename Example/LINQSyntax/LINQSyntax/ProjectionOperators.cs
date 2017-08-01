using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSyntax
{
    class ProjectionOperators
    {
        //Projection Operartors are SELECT and SELECTMANY Clause
        //everytime LINQ Query end with SELECT or GROUPBY Clause
        Data data = new Data();

            //here we want to return all studentNames   using Select Operator
        public void SelectClause()
        {
            var query = from s in data.students select s.StudentName ;
            //or i can use Lambda 
           // var query1 = data.students.Select(s => s.StudentName);
            foreach (var allStudent in query)
            {
                Console.WriteLine("Studentname "+ allStudent);
                //or i can  use it like this
            //    Console.WriteLine("Studentname {0} ", allStudent);
            }
        }

        //The following example of the select clause returns a collection of anonymous type containing the Name and Age property.
        //to select anonymous type it means that you are selecting many data that has different datatype
        public void SelectAnonymoustype()
        {
            var query = from s in data.students select new { Name = s.StudentName , Age = s.Age } ;
            //using lambda
            var Lambda = data.students.Select(s => new { StudenName = s.StudentName, Age = s.Age });
            foreach (var item in Lambda  )
            {
                Console.WriteLine("Studentname {0} , {1}" ,item.StudenName  ,item.Age  );
            }
        }

        //when using SELECTMANY you select from same table but spilt single data
        public void SelectMany()
        {
            var query = from s in data.listingWords select s;
            foreach (var item in query)
            {
                Console.WriteLine("," + item);

            }
            Console.WriteLine("\n");
            //here we want to split each word to be a standalone
            var queryMany = from all in data.listingWords 
                            from eachword in all.Split(' ') select eachword  ;
            foreach (var item in queryMany)
            {
                Console.WriteLine(","+item);

            }
        }
    }
}
