using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSyntax
{
    class LINQLambdaDelegate
    {

        Data data = new Data();
        public delegate bool isTeenager(Student student);
        public delegate bool isYounger(Student student, int Younger);
        public void DelegateLambada()
        {
            Console.WriteLine(".....................................................................\n");
            /* USing Anatomy of the Lambda Expression

             Question:   following anonymous method checks if student is teenager or not:
             */

            //here we use that delegete which we declared it
            //this use Anonymous method of delegate
            Console.WriteLine("Using LINQ with Lambda and Delegate\n");
            isTeenager StudentenTeen = delegate (Student st) { return st.Age > 12 && st.Age < 20; };
            Student teen = new Student() { Age = 25 };

            Console.WriteLine(StudentenTeen(teen));


            //using the delegate with Lambda expresion

            isTeenager LambdaStudentTeen = s => s.Age > 12 && s.Age < 20;

            Student sTeen = new Student() { Age = 25 };
            Console.WriteLine("\nUsing delegate with lambda \n" + LambdaStudentTeen(sTeen));

             Console.WriteLine("Using delegate with Lambda" );
        }


 //-----------------------------------------------------------------------------------------

public void MultipleParameters()
        {
            Console.WriteLine("\n.....................................................................\n");

            //here we want to specify the age and if the student age is less than that age then is true is a teen
            Console.WriteLine("Using Lambda Exprsion with Multiple parameters");

            isYounger isyoungerThan = (student, YoungAge) => student.Age < YoungAge;
            //public delegate bool isYounger(Student student, int Younger);
        Student isyoung = new Student() { Age = 25 };
            Console.WriteLine(isyoungerThan(isyoung, 26));
            if (isyoungerThan(isyoung, 26))
            {
                Console.WriteLine("\ntrue");
            }
            else
            {
                Console.WriteLine("\nFalse");
            }
        }


        //...................................................................................

        /*Using Local Variable in Lmbada Expression body */
        //You can declare a variable in the expression body to use it anywhere in the expression body
        public void LambdaLocalVariable()
        {
            isTeenager lambdaQuery1 = St =>
            {
                int youngAge = 20;
                Console.WriteLine("Lambda expression with multiple statement in the body ");
                //here we return true or false if the specifid age is less or equal to the youngAge
                return St.Age <= youngAge;
            };
            Student ages = new Student() { Age = 18 };//this is the age of the student
            Console.WriteLine(lambdaQuery1(ages));
        }
        
    }
}
