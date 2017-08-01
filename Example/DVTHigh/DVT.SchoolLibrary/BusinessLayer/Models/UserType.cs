using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DVT.SchoolLibrary.BusinessLayer.Models
{
public     class UserType
    {
        public int UserTypeId { get; set; }

        [StringLength (20)]
        public string TypeName { get; set; }

        public virtual ICollection<Learner> Student { get; set; }
        public virtual ICollection<Teacher> Teacher { get; set; }
    }
}
