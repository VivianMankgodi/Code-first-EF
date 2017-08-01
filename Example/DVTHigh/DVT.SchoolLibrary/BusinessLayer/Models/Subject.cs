using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DVT.SchoolLibrary.BusinessLayer.Models
{
    public  class Subject
    {
        public int SubjectId { get; set; }

        public string SubjectCode { get; set; }

        [StringLength(100)]
        public string SubjectName { get; set; }

        public string SubjectDescription { get; set; }

        ////this is many to many student can learn more subject and more subject can be learned by many students
        public virtual ICollection<Learner> Student { get; set; }

        //this is one to many, many subject can be teach by one teacher but teacher can teach my subjects and a many subject can be taught in many standard like in grade 10 to 12 they teach maths but using defferent textbooks, 
      //  public virtual ICollection<Teacher> Teacher { get; set; }
        public virtual ICollection<Standard> Standard { get; set; }
    }
}
