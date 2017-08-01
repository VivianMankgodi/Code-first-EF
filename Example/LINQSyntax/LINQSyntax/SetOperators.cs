using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSyntax
{
    class SetOperators
    {
        Data data = new Data();
        //using Distinc Operator

            //with distinct operator it allow use not to have duplicated data of same row/ person
        public void DistinctOperator()
        {
            //with distint operator it allow not to have duplicates in the result
            var distinctList = data.intlist.Distinct();

           /* foreach (var item in distinctList )
            {
                Console.WriteLine(item );
            }*/

            var distinctstring = data.strList.Distinct();

            //here we want student that are in there but not dublicated student profile if we have one student with dubplicated profile it will only show one profile becuase eveything value for that user is the same so we have used a Class called StudentComperDistinct this class inherit IEqualityComparer Interface 
            var LambadastudentWithoutDistinct = data.students.Select(s=> s.StudentName);
            foreach (var item in LambadastudentWithoutDistinct)
            {
                Console.WriteLine("{0}", item);
            }
            var LINQuery = from s in data.students select new { StudenName = s.StudentName , Age = s.Age };
            foreach (var item in LINQuery)
            {
                Console.WriteLine("{0}, {1}", item.StudenName , item.Age );
            }

            Console.WriteLine("\n");

            var LambadastudentDistinct = data.students.Distinct(new StudentCompereDistinct());
            var studentDistinct1 = (from s in data.students select s).Distinct(new StudentCompereDistinct());
            var studentDistinct2 = (from s in data.students select s).Distinct();
            foreach (var item in LambadastudentDistinct)
            {
                Console.WriteLine("{0}, {1}",item.StudentName ,item.Age);
            }
            //so even here i want to use ComparerClass with Distinct Operator to select teens only
            Console.WriteLine("\n");
            var studentDistinct = (from s in data.students.Where(s => s.Age > 12 && s.Age <21) select s).Distinct(new StudentCompereDistinct());
            foreach (var item in studentDistinct)
            {
                Console.WriteLine("{0}, {1}", item.StudentName, item.Age);
            }

        }

    }

    public class StudentCompereDistinct : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            //with this method we want to comparer if this two StudentId is the same and if is the same it must be true else it must be false and we will use this class in the LINQ query method
            if (x.StudentID == y.StudentID )
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
            return obj.StudentID.GetHashCode();
        }
    }

}
