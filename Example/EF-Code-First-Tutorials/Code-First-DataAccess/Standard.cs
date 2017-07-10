using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_DataAccess
{
    class Standard
    {
        public Standard()
        {

        }


        public int StandardID { get; set; }
        public string Standardname { get; set; }

        //    The Standard(Grade) class should be able to accommodate multiple Students becuase is one to many relationship this means that will use ICollection<> for Student because will make the Standard a Foreign key in Student Table 
        public ICollection<Student> Students { get; set; }
    }
}
