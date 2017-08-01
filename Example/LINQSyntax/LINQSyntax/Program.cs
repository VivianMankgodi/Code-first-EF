using System;
using System.Collections;
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
            // lambda.LambdaLocalVariable();
            //-----------------------------------------------------------------------------------------

            //-----------------------------------------------------------------------------------------
            JoinOperators j = new JoinOperators();
            //j.joinSameValues();
            //-----------------------------------------------------------------------------------------

            StandardOperators standard = new LINQSyntax.StandardOperators();
            //standard.FilterWhere();
            //standard.FilterOfType();
            //standard.Sorting();

            //-----------------------------------------------------------------------------------------
            ProjectionOperators proj = new LINQSyntax.ProjectionOperators();
            //  proj.SelectClause();
            // proj.SelectAnonymoustype();
            //proj.SelectMany();

            //-----------------------------------------------------------------------------------------
            QuantififeirOperator quanOp = new QuantififeirOperator();

            /*quanOp.ALLOperator();
            quanOp.AnyOperator();
            quanOp.ContainOperator();
            quanOp.StudentComparer();
            */

            //-----------------------------------------------------------------------------------------

            ElementOperators element = new LINQSyntax.ElementOperators();

            //element.ElementAtOperator();
            //  element.ElementAtOrDefaultOperator();
            // element.ElementFirstOperato();
            //element.ElementFirstorDefaultOperato();
            //element.ElementLastOperator();
            //element.ElementSkip();

            //-----------------------------------------------------------------------------------------
            SetOperators setOp = new LINQSyntax.SetOperators();

           // setOp.DistinctOperator();

            //-----------------------------------------------------------------------------------------

            Defered df = new LINQSyntax.Defered();
            df.DeferedMethod();
            Console.ReadKey();
        }
    }
}
