using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSyntax
{
    class LinqQuery
    {
        Data data = new Data();
        //this is LINQ Syntax

            public void Query()
        {
            Console.WriteLine("using LINQ Query");

            /* Question : Write a LINQ query that returns a collection of strings which             contains a word "Tutorials"
         # here will use a a LIST remember that List is IEnumerable<> interface
         */
            //here we want to return all the words that has  the word tutorials


               var query = from t in data.listingWords  where t.Contains("Tutorials") select t;

               //here we are testing it to make sure that it return  what we want that is why we used FOREACH LOOP
               Console.WriteLine("Selecting Words that has Tutorials in them.....\n");
               foreach (var item in query)
               {
                   Console.WriteLine(item );
               }


 //-----------------------------------------------------------------------------------------

            /* Question : find out teenager students from  the Student collection in(sequence)
            remember that teens start from 13 until 19 so we must put && like as we did in the studentQuery
            */

            Console.WriteLine("\nReturning t students that are teenagers\n");
                               var studentQuery = (from st in data.students  where st.Age > 12 && st.Age < 20 select st ).ToList() ;

                          foreach (var std in studentQuery )
                          {
                              Console.WriteLine("Name " + std.StudentName + " Age "+std.Age );
                          }
           
        }

    }
}
