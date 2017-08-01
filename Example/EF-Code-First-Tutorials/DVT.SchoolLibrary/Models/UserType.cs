using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DVT.SchoolLibrary.Models
{
public     class UserType
    {
        public int UserTypeID { get; set; }

        [StringLength (20)]
        public string TypeName { get; set; }

        public virtual ICollection<Learner> Student { get; set; }
        public virtual ICollection<Teacher> Teacher { get; set; }
    }
}
