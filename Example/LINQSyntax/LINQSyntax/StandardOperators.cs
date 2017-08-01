using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSyntax
{
    class StandardOperators
    {
        Data data = new Data();
        //here will use Filtering the filtering use two Query Operators which is WHERE or OfType it just depend on you which one you want to use

        public void FilterWhere()
        {
            //here we will use Lambda expression with where filtering, everytime we must select the Standard operators always go with SELECT
            /*Q:    The following query sample uses a Where operator to filter the            students who is teen ager from the given collection (sequence). It        uses a lambda expression as a predicate function.*/
            var queryLambda = data.students.Where(steen => steen.Age > 12 && steen.Age < 21).ToList();
            Console.WriteLine("Students that are still Teenagers are:" );
           foreach (var teen in queryLambda )
            {
                Console.WriteLine(" Student name: {0}, student Age: {1} ", teen.StudentName, teen.Age);
            }

            //or you can use LINQ Syntax straight

            /* var queryLINQ = from steen in data.students where steen.Age > 12 && steen.Age < 21 select new { steen.StudentName, steen.Age  };

             foreach (var teen in queryLINQ )
             {
                 Console.WriteLine(" Student name: {0}, student Age: {1} ", teen.StudentName, teen.Age);
             }
            
            or you can use it like this

            List<Student> listStudent = new List<Student>();
            Func<Student, bool> DelegateQuery = delegate (Student s) { return s.Age > 12 && s.Age < 21;  };
            var filteredResult = from s in data.students  where DelegateQuery(s) select s;

            foreach (var item in filteredResult)
            {
                Console.WriteLine(item.StudentName +" "+item.Age );
            }*/
            Console.WriteLine("using WHERE Clause with index ");
            /*Q: The following example uses the Where clause to filter out odd elements     in the collection and return only even elements. Please remember that   index starts from zero.
             * becuase we only need even index not odd index this mean that it has to display only index number that can be divide by 2 without reminders
             */
            var filterResult = data.students.Where((s, i) =>
            {
                if (i % 2 == 0) { return true; }
                else
                {
                    return false;
                }
            });

            foreach (var Evenindex in filterResult )
            {
                //here will show studentName which Index numbers are divied by 2 without reminder and remember that index start from zero 
                Console.WriteLine(Evenindex.StudentName );
            }
        }


        
        public void FilterOfType()
        {
            Console.WriteLine("Filtering with OfType ");
            //here we only need values that are string only from MixedList List
            var stringResult = from m in data.mixedList.OfType<string>() select m;
            Console.WriteLine("This shwo only type of String datatype");
            foreach (var item in stringResult )
            {
                Console.WriteLine(item);
            }

            var intResult = from m in data.mixedList.OfType<int>() select m;
            Console.WriteLine("This shwo only type of int datatype");
            foreach (var item in stringResult)
            {
                Console.WriteLine(item);
            }

            var StudentResult = from m in data.mixedList.OfType<Student >() select m;
            Console.WriteLine("This shwo only type of Student datatype/class");
            foreach (var item in StudentResult)
            {
                Console.WriteLine("{0}, {1}",item.StudentID, item.StudentName );
            }
        }

        //another Standard Operator is Sorting which has this operators OrderBy, OrderByDescending, ThenBy, ThenByDescending, Reverse
        public void Sorting()
        {
            //The following example sorts the studentList collection in ascending order of StudentName using OrderBy extension method
            Console.WriteLine("Sorting Operator");
            Console.WriteLine("Sorting in Ascending Order");
            var AscendingSort = from s in data.students orderby s.StudentName select s;
            foreach (var item in AscendingSort)
            {
                Console.WriteLine(item.StudentName);
            }
            Console.WriteLine("Sorting in Descending Order");
            var desecendingSort = from s in data.students orderby s.StudentName descending select s;
            foreach (var item in desecendingSort)
            {
                Console.WriteLine(item.StudentName);
            }

            Console.WriteLine("Sorting in Reverse Order");
            var reverseSort = (from s in data.students select s.StudentName).Reverse();
            foreach (var item in reverseSort)
            {
                Console.WriteLine(item);

            }
        }



        }
}
