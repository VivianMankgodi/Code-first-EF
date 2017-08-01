using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Methods.DataAccess
{
   public  class Standard
    {
        public Standard()
        {

        }

        /* decaring Scalar properties*/
        public int StandardID { get; set; }
        public string Standardname { get; set; }
        //public int Standardcode { get; set; }

        /* decaring Colection Navigation properties*/

        //    The Standard(Grade) class should be able to accommodate multiple Students becuase is one to many relationship this means that will use ICollection<> for Student because will make the Standard a Foreign key in Student Table 
        //public ICollection<Student> Students { get; set; }
        //i can even use it like this
        public IList<Student> Students { get; set; }

        public static implicit operator Standard(List<Student> v)
        {
            throw new NotImplementedException();
        }
    }
}
