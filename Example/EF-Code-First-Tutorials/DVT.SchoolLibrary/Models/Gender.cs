using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DVT.SchoolLibrary.Models
{
   public class Gender
    {
        public int GenderID { get; set; }

        [StringLength(6)]
        public string  Type { get; set; }
        public virtual ICollection<Learner> Student { get; set; }
        public virtual ICollection<Teacher> Teacher { get; set; }
    }
}
