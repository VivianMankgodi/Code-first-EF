using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSyntax
{
    class Data
    {
        public IList<Student> students = new List<Student>()
            {
                new Student (){ StudentID = 1, StudentName = "Jonh", Age = 13},
                new Student() { StudentID =3 , StudentName = "Bill", Age = 20},
                new Student() { StudentID = 3, StudentName = "Bill", Age = 20},
                new Student() { StudentID = 4, StudentName = "Ram", Age = 25},
                new Student() { StudentID = 5, StudentName = "Ron", Age = 20},
                new Student() { StudentID = 6, StudentName = "Chris", Age = 31},
                new Student() { StudentID = 7, StudentName = "Rob", Age = 22},
            };

        //creating a list that has values
    public     IList<string> listingWords = new List<string>() {
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials",
                "Java"};


       public IList mixedList = new ArrayList() {

          0,
       "One",
           "two",
         3,
        new Student() { StudentID = 1, StudentName = "Bill" }};
        public void mixed()
        {
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("two");
            mixedList.Add(3);
            mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });
        }

   public      IList<int> intlist = new List<int>() { 13, 21, 30, 45, 50, 87, 21, 87, 21 };
     public    IList<string> strList = new List<string>() { "One", "Two", null, "Four", "Five" , "One", "One", "Five"};
        public IList<string> EmptyString = new List<string>();

    }
}
