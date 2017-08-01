using Linq.ShoolLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.ShoolLibrary.Models
{
  public   class Teacher
    {
        public Teacher()
        {

        }

        public int TeacherID { get; set; }
        public string TeacherName { get; set; }
        public string Surname { get; set; }
        public virtual ICollection<Student> students { get; set; }
    }
}
