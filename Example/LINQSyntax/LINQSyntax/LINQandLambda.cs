using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSyntax
{
    class LINQandLambda
    {

        Data data = new Data();
      

        public void LINQMethod()
        {
            Console.WriteLine(".....................................................................");
            // USING LINQ METHOD SYNTAX
            Console.WriteLine("\nUsing LINQ Method Syntax with Lambda Expresion\n  Returning students that are teenagers");
            //here we use LINQ Method Syntax with IEnumerable<> Collecrtion
            var StudentAge = data.students.Where(st => st.Age > 12 && st.Age < 20).ToList<Student>();//this show that is IEnumerable<T> Collection of List

            foreach (var stu in StudentAge)
            {
                Console.WriteLine(stu.StudentName);
            }

            Console.WriteLine("\nSelecting Words that has Tutorials in them.....\n");

            var WordTutorials = data.listingWords.Where(word => word.Contains("Tutorials"));
            foreach (var itemWord in WordTutorials)
            {
                Console.WriteLine(itemWord);
            }
        }





    }
}
