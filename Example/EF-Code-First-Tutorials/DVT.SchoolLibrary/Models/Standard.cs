using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DVT.SchoolLibrary.Models
{
  public   class Standard
    {
        // public int StandardID { get; set; }
        //this two FK will be my PK in here
        public int TeacherID { get; set; }
        public int SubjectID { get; set; }

        [StringLength(10)]
        public string StandardName { get; set; }
        
        // a Learner belong to one standards but standard can have many learners
        public virtual ICollection<Learner> Learner { get; set; }

        //a teache can teach many standard and many standard can be taught by many teachers
       public virtual ICollection<Teacher> Teacher { get; set; }
        public virtual ICollection<Subject> Subject { get; set; }

    }
}
