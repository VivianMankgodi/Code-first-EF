using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL.Methods.DataAccess;
using System.IO;

namespace SchoolInformation
{
    class Program
    {
        static void Main(string[] args)
        {

            //adding a user to a DbContext( database)
            /*  using (var context = new SchoolContext() )
              {
                  //here we add information from a Class(table) that we want 

                 var stud = new Student
                  {
                      StudentName = "Thabo",
                      DateOfBirth = DateTime.Parse("1991-04-12")


                  };

                 // context.students.Add(stud);
                //  context.SaveChanges();
              //    Console.WriteLine("Student Saved");


                  string Name;
                  DateTime BirthDate;
                  Console.Write("Enter your name");
                  Name = Console.ReadLine();
                  var st = new Student()
                  {
                      StudentName = Name
                  };
                  context.students.Add(st);
                  context.SaveChanges();
                  Console.WriteLine(Name + "You where saved");
                  Console.ReadKey();
              }*/

            MethodsInsert method = new MethodsInsert();
            method.InsertStudent();
        }
    }
}
