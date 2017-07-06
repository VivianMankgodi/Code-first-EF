using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Methods.DataAccess.Methods
{
    public class Insert
    {
        SchoolContext dbContext = new SchoolContext();

        public void CourseInsert(string coursename)
        {
            Course course = new Course(coursename);
            //here we are addig new course
            dbContext.Courses.Add(course);
            // saving the course
            dbContext.SaveChanges();
          //  return course.CourseId;

        }



        //here i want to insert a new student and enrol the srtudent into course (existingcourse) this must save the student into studentTable and then save studentID and CourseId into StudentCourseTable 
        public void StudnetInsertWithCourse(string studentName,  decimal height, float weight, int? gender, int? standardID, int? teacherID, DateTime? dateOfBirth, int CourseId)
        {
            //here we must select a course that student want to enroll in by using courseId
            var cour = dbContext.Courses.Where(c => c.CourseId == CourseId).FirstOrDefault();

            //here we call student properties 
            Student stud = new Student(studentName, height, weight, gender, standardID, teacherID, dateOfBirth);

            //here we list a courseInfo 
            stud.Courses   = new List<Course>();

            //here we add course into student  but automatically will save both ID into StudentCourseTable
            stud.Courses.Add(cour);

            //here we save the student into StudentTable
            dbContext.students.Add(stud );
            dbContext.SaveChanges();

        }

        //this method will enroll a student into another course both student and course are existing
        //here we need just Pks of both tables Student and the Course
        public void AddingNewStudentCourse(int studentid, int Courseid )
        {
            //here we select specific course with courseI and student with studentId
            
            var student = dbContext.students.Where(s => s.StudentID == studentid).FirstOrDefault();
            var course = dbContext.Courses.Where(c => c.CourseId == Courseid).FirstOrDefault();

            student.Courses = new List<Course>();

            //here we add both student and course into the context
            //so i must add both course into student object/class and student to course object/class so that it can know which one i want to use
            student.Courses.Add(course );
            course.Students.Add(student);
         
            //then we save the changes into StudentCourseTable
            dbContext.SaveChanges();

        }



        //this method we want to remove  a studnet to the course that they passed
        public void RemoveStudentCourse(int studentid, int Courseid)
        {
           
            var removeStudent = dbContext.students.Where(s => s.StudentID == studentid).FirstOrDefault();
            var removeCourse = dbContext.Courses.Where(c => c.CourseId == Courseid).FirstOrDefault();

            //    removeCourse.Students = new List<Student>();
            removeCourse.Students.Remove(removeStudent);
            dbContext.SaveChanges();
          
        }
        public void StudnetInsert(string studentName, decimal height, float weight, int? gender, int? standardID, int? teacherID, DateTime? dateOfBirth)
        {
            Console.Write("Enter studentName: ");
            studentName = Console.ReadLine();
            Console.Write("Enter date Of Birth :");
            dateOfBirth = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter height :");
            height = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter weight :");
            weight = float.Parse(Console.ReadLine());
            Console.Write("Enter gender :");
            gender = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter standardID :");
            standardID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter teacherID :");
            teacherID = Convert.ToInt32(Console.ReadLine());
            Student student = new Student(studentName, height, weight, gender, standardID, teacherID, dateOfBirth);
            dbContext.students.Add(student);
            dbContext.SaveChanges();
        }

    }
}
