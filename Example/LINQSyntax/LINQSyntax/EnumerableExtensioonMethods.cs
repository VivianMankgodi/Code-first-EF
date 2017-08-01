using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSyntax
{
    public static class EnumerableExtensioonMethods
    {
        
        public static IEnumerable<Student> GetTeenAgerStudents(this IEnumerable<Student> source)
        {
            foreach (Student std in source)
            {
                Console.WriteLine("Accessing student {0} ", std.StudentName);
                if (std.Age > 12 && std.Age < 20)
                    yield return std;


            }
        }

       
    }


    public class Defered
    {
        public void DeferedMethod()
        {
            Data data = new Data();
            var teen = (from s in data.students.GetTeenAgerStudents() select s ).Distinct(new StudentCompereDistinct());

            foreach (var item in teen )
            {
                Console.WriteLine("Accessing Student:  {0} ", item.StudentName );
            }
        }
    }
}
