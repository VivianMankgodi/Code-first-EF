using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVT.School.PresentationLayer;

namespace DVT.School
{
    class Program
    {
        static void Main(string[] args)
        {
            Accessing acc = new Accessing();
            //acc.InsertLearner("t", "s", "123", "E", "01", 1, 1, false );

            acc.NewLearner();

            Console.WriteLine(@"saved");
        }
    }
}
