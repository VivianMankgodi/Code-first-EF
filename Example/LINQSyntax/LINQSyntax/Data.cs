using System;
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
                new Student (){ StudentID = 1, StudentName = "Jonh", Age = 18},
                new Student() { StudentID = 2, StudentName = "Steve", Age = 21},
                new Student() { StudentID = 3, StudentName = "Bill", Age = 20},
                new Student() { StudentID = 4, StudentName = "Ram", Age = 25},
                new Student() { StudentID = 5, StudentName = "Ron", Age = 20},
                new Student() { StudentID = 6, StudentName = "Chris", Age = 31},
                new Student() { StudentID = 7, StudentName = "Rob", Age = 19},
            };

        //creating a list that has values
    public     IList<string> listingWords = new List<string>() {
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials",
                "Java"};

    }
}
