using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVT.SchoolLibrary;
using DVT.SchoolLibrary.Models;
using DVT.SchoolLibrary.Context;

namespace Ef6Library
{
    public class Class1
    {

        //creating Asynchronous query
        private static async Task<Learner> GetLearner()
        {
            Learner myLearner = null;
            using (var context = new DVTSchoolContext())
            {
                Console.WriteLine(@"Start GetLearner....");
                myLearner  = await (context.Students.Where(l => l.LearnerID == 1).FirstOrDefaultAsync<Learner>());
                Console.WriteLine(@"Finished getLearner........");
            }

            return stu
        }

    }
}
