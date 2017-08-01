using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVT.SchoolLibrary;
using DVT.SchoolLibrary.Models;
using DVT.SchoolLibrary.Repositories;
using DVT.SchoolLibrary.DataAccess;

namespace DVT.School
{
    class Program
    {
        static void Main(string[] args)
        {
            //here we want to use the Repository by calling LearnerRepo becuase when we call LearnerRepo we are saying that it must take every method from this class and every methods from the class it inherate and by this we means that LearnerRepo it inherite Repository class
            Results result = new Results();
            result.GetGenders();
        }
    }
}
