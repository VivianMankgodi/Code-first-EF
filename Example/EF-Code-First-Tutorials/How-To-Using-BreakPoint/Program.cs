using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace How_To_Using_BreakPoint
{
    class Program
    {
        //to use break point you must click the line you want the breakepoint and on the leftside of the Visual Studio click on the second column from left on the like you want the breake point to be OR you can press F9 

        static void Main(string[] args)
        {
            var fruits = new string[] { "Pair", "Grape", "Orange", "Kiwi", "Peach", "Apple", "Pineapple", "Watermelon" };

            DoWork(fruits);
            Console.ReadKey();
        }



    public static void DoWork(IEnumerable<string > items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);

            }
        }

    }
}
