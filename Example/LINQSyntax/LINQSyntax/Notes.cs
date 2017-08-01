using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSyntax
{
    class Notes
    {
        /*
        Using LINQ Query Syntax
        @ LINQ Query Syntax start with FROM keyword
        @ It ends with SELECT keyword or GROUPBY Clauese.

        Syntax of LINQ 
        var VariableName = FROM rangeVariable IN  Sequence(IEnumerable or IQueryable Collection) WHERE rangeVariable.ConditionExpresion() SELECT rangeVariable;
e.g
        list<string> strList = new List(){"Tutotrials1", "One two", "2 Tutorials"};
        var result = FROM s in strList WHERE s.Constains("Tutorials) SELECT s;

        */

        /*
        Using LINQ Method Syntax  
        
        @ it use Lambda Expresion
        by using LINQ method we don't specify FROM  because we use Lambda Expresion

        LINQ method syntax
        var VariableName =  EntityNameSequence.WHERE (rangeVariable.Condition());

e.g
        var StudentAge =  Students.WHERE(st => st.Age > 12 && st.Age< 20);

        */

        /*
            USing Anatomy of the Lambda Expression

         @ is like using Anonymous method of C# that has delegete in it
         @You can se Lambda Exprsion with single parameters
         @You can se Lambda Exprsion with Multiple parameters
         @You can se Lambda Exprsion without parameters

e.g
   
           public delegate void print(int value);// we declare delegate outside the method but inside the class


        public delegate void Print(int value);
            static void Main(string[] args)
            {
                Print print = delegate(int val) { 
                    Console.WriteLine("Inside Anonymous method. Value: {0}", val); 
                };

             print(100);
           }


            */
    }
}
