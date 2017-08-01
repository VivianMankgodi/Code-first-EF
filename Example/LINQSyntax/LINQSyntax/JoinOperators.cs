using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSyntax
{
    class JoinOperators
    {
        IList<string> strList1 = new List<string>()
        {
            "One",
            "Two",
            "Three",
            "Four"
        };
        IList<string> strList2 = new List<string>()
        {
            "One",
            "Two",
            "Five",
            "Six"
            
        };

        IList<Students> studentList = new List<Students>()
             { new Students() { StudentID = 1, StudentName = "John", StandardID = 1 }, new Students() { StudentID = 2, StudentName = "Moin", StandardID = 1 }, new Students() { StudentID = 3, StudentName = "Bill", StandardID = 2 }, new Students() { StudentID = 4, StudentName = "Ram", StandardID = 2 }, new Students() { StudentID = 5, StudentName = "Ron" } };

             IList<Standard> standardList = new List<Standard>() {
                     new Standard() { StandardID = 1, Standardname= "Standard 1" }, new Standard() { StandardID = 2, Standardname= "Standard 2" }, new Standard() { StandardID = 3, Standardname= "Standard 3" } };
        public void joinSameValues()
        {
            var innerJoin = strList1.Join(strList2, s1 => s1, s2 => s2, (s1, s2) => s1);
            foreach (var item in innerJoin )
            {
                Console.WriteLine(item );

            }
            // first when i use LINQ Join Syntax not lambda star with FROM  then FirstTableName JOIN with the SecondTableName ON ID that make those table tto have relationship PK FK then SELECT NEW {in here you specify the columns that you want to display as your result} 
            var joi = (from s1 in studentList join s2 in standardList on s1.StandardID equals s2.StandardID select new { s1.StudentID, s1.StudentName, s2.Standardname });
            //here i must put it on Foreach loop so that i will display it
            foreach (var item in joi )
            {
                Console.WriteLine("StudentID: {0} , Student Name: {1} , Standard Name: {2}", item.StudentID, item.StudentName, item.Standardname );
            }
        }

    }

    public class Students
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int StandardID { get; set; }
    }

    public class Standard
    {
        public int StandardID { get; set; }
        public string Standardname { get; set; }

    }
}
