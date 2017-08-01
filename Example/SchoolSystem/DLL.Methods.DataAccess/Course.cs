using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Methods.DataAccess
{
    public class Course
    {
        public Course()
        {
         //   this.Students = new HashSet<Student>();
        }

        public Course(string courseName)
        {
         
            CourseName = courseName;
           
        }
        [Required ,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
