using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Methods.DataAccess.Methods
{
   public  class Select
    {
        SchoolContext context = new SchoolContext();
        public  void GetAllStudent()
        {        
            var query = (from s in context.students select s).ToList();
            foreach (var student in query)
            {
                Console.WriteLine(student.StudentName);
            }
        }


        public void GetById(int id)
        {
            var query = from s in context.students where s.StandardID == id select s;
            Console.Write("enter your id ");
            id = Convert.ToInt32(Console.ReadLine());
            foreach (var item in query)
            {
                Console.WriteLine(item.StudentID + " " + item.StudentName);
            }
                      
        }
    }
}
