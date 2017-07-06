using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSyntax
{
    class Program
    {
     
        // to check if the student is a teenager we must use delegate bool because we are cheking
        public delegate bool isTeenager(Student student);
        public delegate bool isYounger(Student student, int YoungAge);
        static void Main(string[] args)
        {
            LinqQuery linqQuery = new LinqQuery();
            //linqQuery.Query();



            //-----------------------------------------------------------------------------------------
            LINQandLambda LINQ = new LINQandLambda();
         ///   LINQ.LINQMethod();
//-----------------------------------------------------------------------------------------

            LINQLambdaDelegate lambda = new LINQLambdaDelegate();

            //  lambda.DelegateLambada();
            //  lambda.MultipleParameters();
            lambda.LambdaLocalVariable();
            //-----------------------------------------------------------------------------------------


            Data data = new Data();
            

            Console.ReadKey();
        }
    }
}
