using DLL.Methods.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Methods.DataAccess.Methods
{
    public class Select
    {
        SchoolContext context = new SchoolContext();
        public void GetAllStudent()
        {
            var query = (from s in context.students select s).ToList();
            foreach (var student in query)
            {
                Console.WriteLine(student.StudentName);
            }
        }


        public void GetById(int id)
        {
            Console.Write("enter your id ");
            id = Convert.ToInt32(Console.ReadLine());
            /*   var query = from s in context.students where s.StandardID == id select s;

               foreach (var item in query)
               {

                   id = Convert.ToInt32(Console.ReadLine());

                   Console.WriteLine(item.StudentID + " " + item.StudentName);
               }*/

            var query = context.students.Where(s => s.StudentID == id).FirstOrDefault();
            Console.WriteLine("Studnt ID : " + query.StudentID + "\nStudent Name: " + query.StudentName + "\nTeacherName: " + query.teacher.TeacherName + "\nDateOfBirth: " + query.DateOfBirth + /*"\nGenderType: "+ query.Gender .genderID + */"\nStandardname: " + query.standard.Standardname);


            //       Console.WriteLine("\n\nStudnt ID : " + query.StudentID + "\nStudent Name" + query.StudentName, query.teacher.TeacherName, query.DateOfBirth, query.Gender.GenderType, query.standard.Standardname);
        }


        //using Inner Joins to join Student with Standard  using StandardID
        public void joining()
        {
            Student stud1 = new Student();
            Standard stand1 = new Standard();
           //IList<Student> studentList = new List<Student>();
           // IList<Standard> standardList = new List<Standard>();
           List<Student> studentInfo = context.students.ToList();
            List<Standard> standards =context.standards.ToList();

             /*IList<Student> studentList = new List<Student>()
             { new Student() { StudentID = 1, StudentName = "John", StandardID = 1 }, new Student() { StudentID = 2, StudentName = "Moin", StandardID = 1 }, new Student() { StudentID = 3, StudentName = "Bill", StandardID = 2 }, new Student() { StudentID = 4, StudentName = "Ram", StandardID = 2 }, new Student() { StudentID = 5, StudentName = "Ron" } };

             IList<Standard> standardList = new List<Standard>() {
                     new Standard() { StandardID = 1, Standardname= "Standard 1" }, new Standard() { StandardID = 2, Standardname= "Standard 2" }, new Standard() { StandardID = 3, Standardname= "Standard 3" } };
 */

            //   var join = stude

            // var innerjoinResult = studentList.Join(standardList , student => student.StudentID, standard=> standard.StandardID, (student, standard)=>new { StudentName = student.StudentName, Standardname = standard.Standardname });
            var innerjoinResult = standards.Join(studentInfo, standard => standard.StandardID,  student => student.StudentID, (standard,student) => new { Standardname = standard.Standardname, StudentName = student.StudentName });
           /* foreach (var item in innerjoinResult )
            {
                Console.WriteLine("ww");
                Console.WriteLine("{0} - {1} ", item.StudentName, item.Standardname);
            }*/

            var joing = (from stu in context.students join stand in context.standards on stu.StandardID equals stand.StandardID select new { stu.StudentName, stand.Standardname });
            foreach (var item in joing)
            {
                Console.WriteLine("{0} - {1} ", item.StudentName, item.Standardname);
            
            }
            Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------\n");
           
            var innerjoin = ( from stu in context.students join teach  in context.Teachers  on stu.TeacherID equals teach.TeacherID select new { stu.StudentName , teach.TeacherName, teach.Surname });

            foreach (var TS in innerjoin )
            {
                Console.WriteLine(" Student Name: {0}, Teacher Name: {1} , Teacher Surname: {2}   ", TS.StudentName, TS.TeacherName, TS.Surname    );
            }
            Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------\n");
            var Threeinnerjoin = (from stu in context.students join teach in context.Teachers on stu.TeacherID equals teach.TeacherID join stand in context.standards on stu.StandardID equals stand.StandardID  select new { stu.StudentName, teach.TeacherName, teach.Surname, stand.Standardname  });

            foreach (var TS in Threeinnerjoin)
            {
                Console.WriteLine(" Student Name: {0}, Teacher Name: {1} , Teacher Surname: {2} , Standar name: {3}  ", TS.StudentName, TS.TeacherName, TS.Surname, TS.Standardname );
            }

            Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------\n");
            var Whereinnerjoin = (from stu in context.students join teach in context.Teachers on stu.TeacherID equals teach.TeacherID join stand in context.standards on stu.StandardID equals stand.StandardID where teach.TeacherName == "Mako"  select new { stu.StudentName, teach.TeacherName, teach.Surname, stand.Standardname } );

            foreach (var TS in Whereinnerjoin)
            {
                Console.WriteLine(" Student Name: {0}, Teacher Name: {1} , Teacher Surname: {2} , Standar name: {3}  ", TS.StudentName, TS.TeacherName, TS.Surname, TS.Standardname);
            }


            Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------\n");
            /* var many2manyRinnerjoin = (from stu in context.students join teach in context.Teachers on stu.TeacherID equals teach.TeacherID join stand in context.standards on stu.StandardID equals stand.StandardID where teach.TeacherName == "Mako" select new { stu.StudentName, teach.TeacherName, teach.Surname, stand.Standardname });

             foreach (var TS in Whereinnerjoin)
             {
                 Console.WriteLine(" Student Name: {0}, Teacher Name: {1} , Teacher Surname: {2} , Standar name: {3}  ", TS.StudentName, TS.TeacherName, TS.Surname, TS.Standardname);
             }*/

//            var many2manyRinnerjoin = (from c in context.Courses join s in context.students on c.CourseId equals s.StudentID  select new { c.CourseId, c.CourseName , s.StudentName });
           // var id = 5;
           // var many2manyRinnerjoin = from c in context.Courses join s in context.students on  where c.Students.Any(s => s.StudentID == id)select new {c.CourseId, c.CourseName, ;

           // var many2manyRinnerjoin =  context.students.Where(s=>s.Courses.Any(c=>c.CourseId ==CourseId))

              var j = from s in context.students from c in s.Courses where c.CourseId == c.CourseId select new  { c.CourseId, c.CourseName, s.StudentName  };
            foreach (var item in j)
            {
                Console.WriteLine("CourseID: {0} , course name: {1} , Student name: {2} ", item.CourseId, item.CourseName, item.StudentName );
            }
        }



    }
}
