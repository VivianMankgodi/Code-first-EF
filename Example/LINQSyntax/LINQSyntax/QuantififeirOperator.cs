using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSyntax
{
    class QuantififeirOperator
    {
        Data data = new Data();
        //Quantifierr Operators are ALL, ANY, CONTAIN this operators must statisfy specific rquirement/condition this operators return Boolean values which can be true or false
        //The quantifier operators evaluate elements of the sequence on some condition and return a boolean value to indicate that some or all elements satisfy the condition.

        //here we use ALL operator to check if all the student are teenager and again to check if listword has tutorial
        public void ALLOperator()
        {
            //with All Operator we want to check if all the data in that class/table has what condition say like here we want to check if all the student are teenager and for use to check that we must specify that condition and remember that teens start from 13 to 20 that is why we said age is greater than 122 but less than 21 so if the the data on Age column they are all  from 13 to 20 it will say true else it must return false
            var all = data.students.All(teen=> teen.Age >12 && teen.Age<21);
            var allList = data.listingWords.All(word => word == "C# Tutorials");
            Console.WriteLine(all + " "+ allList );
         
        }

        public void AnyOperator()
        {
            var any = data.students.Any(teen => teen.Age > 12 && teen.Age < 21);
            var anyList = data.listingWords.Any(word => word == "C# Tutorials");
            Console.WriteLine(any +" "+ anyList);
        }




        //CONTAIN OPERATORS
        public void ContainOperator()
        {
            var contailMixeddList = data.mixedList.Contains(0);
            var contailMixedd = data.mixedList.Contains(1);
            var containList = data.listingWords.Contains("Tutorials");
           
            Console.WriteLine(contailMixeddList + " "+ contailMixedd  + " " + containList);
        }

        public void StudentComparer()
        {
            Student stu = new Student() { StudentID = 7, StudentName = "Rob" };
            var result = data.students.Contains(stu, new StudentComparer() );
            Console.WriteLine(result );
        }
        /* public static bool Contain<Student>(this IEnumerable<Student> source, Student value)
         {

         }
         public static bool Contains<Student>(this IEnumerable<Student>, Student value, IEqualityComparer<StudentComparer> comparer);
         */
    }


    public class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x.StudentID == y.StudentID  && x.StudentName.ToLower() == y.StudentName.ToLower() )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode(Student obj)
        {
            return obj.GetHashCode();
        }
    }
}
