using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_DataAccess
{
    class Student
    {
        //here is the constructr method
        public Student()
        { }

        //here we will create properties for Student Class(Table)
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        //here show that Standard will be a foreign key in here
        public Standard standard { get; set; }
    }
}
