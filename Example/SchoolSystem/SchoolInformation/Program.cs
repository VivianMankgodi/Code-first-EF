using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL.Methods.DataAccess;
using System.IO;
using DLL.Methods.DataAccess.Methods;

namespace SchoolInformation
{
    class Program
    {
        static void Main(string[] args)
        {

            Insert method = new Insert();
            Select selectMethod = new Select();
            int id = 0;
           // method.RemoveStudentCourse(5,1);
            method.AddingNewStudentCourse(5, 1);
           //  method.CourseInsert("C#");
           //method.StudnetInsertWithCourse("Viv",00,00,1,1,1, Convert.ToDateTime("2003/12/12"),1);
           // selectMethod.GetAllStudent();
           //selectMethod.GetById(id);
           // method.StudnetInsert("Studentname",Convert.ToDateTime("2007/02/11"), Convert.ToDecimal(10.0),10,1,1,1);
            string studentName ="";
                DateTime? dateOfBirth = DateTime.Now;
            decimal height = 00.0m; 
                float weight = 0;
            int? gender=null;
            int? standardID = null;
            int? teacherID= null;
           // method.StudnetInsert(studentName,   dateOfBirth,  height,  weight, gender,  standardID,   teacherID);

            

            //adding a user to a DbContext( database)
           

           // MethodsInsert method = new MethodsInsert();
        //    method.InsertStudent();
        }


    }
}
