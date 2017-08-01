using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSyntax
{
    class ElementOperators
    {
        Data data = new Data();        //Element operators return a particular element from a sequence (collection) its operatos are ElementAt, First, FirstOrDefault, Last, LastOrDefault, Single, SingleOrDefault

        //here we will use ElementAt() operator The ElementAt() method returns an element from the specified index from a given collection. If the specified index is out of the range of a collection then it will throw an Index out of rangeexception. Please note that index is a zero based index
        public void ElementAtOperator()
        {


            // when i want to specify the element with index i use ElementAt or ElementAtOrDefault operator
            Console.WriteLine("here we want to show the 1st Element in int list: {0}", data.intlist.ElementAt(0));
            Console.WriteLine("here we want to show the 4th Element in int list: {0}", data.intlist.ElementAt(3));

            //this one will throw an error becuase we don't have index number 6
           // Console.WriteLine("here we want to show the 4th Element in int list: {0}", data.intlist.ElementAt(6));
        }

        //here want to use ElementAtorDefault  with this one if the index number is out of range meaning the is no value for that index it will display th defult value not an error i better than ElementAt, for example if i a list value of number and i have only 4 values and that means i have 3 index because index start from zero and if i specify index 4 for ElementAtOrDefualt it will return the default remeber that default value for index is 0 or null

        public void ElementAtOrDefaultOperator()
        {
            Console.WriteLine("here we want to show the 1st Element in int list: {0}", data.intlist.ElementAtOrDefault(0));
            Console.WriteLine("here we want to show the 4th Element in int list: {0}",data.intlist.ElementAtOrDefault(3));

            // here we specify index number 6 and we don't have it and it will not throw an error but it will return default value which is zero 0
            Console.WriteLine("here we want to show the 7th Element in int list: {0}", data.intlist.ElementAtOrDefault(6));
            Console.WriteLine("index 5 in string {0}: ", data.strList.ElementAtOrDefault(5));
        }
        public void ElementFirstOperato()
        {
            Console.WriteLine("here we want to show the 1st Element in int list: {0}", data.intlist.First());
            Console.WriteLine("here we want the first Even number from intList: {0}", data.intlist.First(i=> i % 2 ==0));

            Console.WriteLine("here we want the first string value: {0}", data.strList.First());

            //this will give error becuase this list it have no value/data
         //   Console.WriteLine("this is empty string: {0}", data.EmptyString.First());
        }


        public void ElementFirstorDefaultOperato()
        {
            Console.WriteLine("here we want to show the 1st Element in int list: {0}", data.intlist.FirstOrDefault ());
            Console.WriteLine("here we want the first Even number from intList: {0}", data.intlist.FirstOrDefault(i => i % 2 == 0));

           Console.WriteLine("here we want the first string value: {0}", data.strList.FirstOrDefault());

            //this will give us default value becuase this list it have no value/data
           Console.WriteLine("this is empty string: {0}", data.EmptyString.FirstOrDefault());
        }

        public void ElementLastOperator()
        {
            Console.WriteLine("here we want to show the last Element in int list: {0}", data.intlist.Last());
            Console.WriteLine("here we want the last Even number from intList: {0}", data.intlist.Last(i => i % 2 == 0));
        }

        public void ElementLastOrDefaultOperator()
        {
            Console.WriteLine("here we want to show the last Element in int list: {0}", data.intlist.LastOrDefault());
            Console.WriteLine("here we want the last Even number from intList: {0}", data.intlist.LastOrDefault(i => i % 2 == 0));
            //this will give us default value becuase this list it have no value/data
            Console.WriteLine("this is empty string: {0}",data.EmptyString.LastOrDefault());
        }

        //The Skip() method skips the specified number of element starting from first element until the number element/value you specified  and returns rest of the elements.
        public void ElementSkip()
        {
            Console.WriteLine("skipping two values from the first value");
            var skip = data.intlist.Skip(2);
            foreach (var item in skip )
            {
                Console.WriteLine("{0}", item .ToString() );
            }

            var stringlist = data.strList.Skip(3);
            foreach (var item in stringlist )
            {
                Console.WriteLine("{0}", item.ToString());
            }
        
        }
    }
}
