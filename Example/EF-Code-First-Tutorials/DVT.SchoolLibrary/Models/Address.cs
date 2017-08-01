using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DVT.SchoolLibrary.Models
{
 public   class Address
    {
        public int AddressID { get; set; }
        [Required ]
        public string HouseNumber { get; set; }
        [Required]
        public string UnitNo { get; set; }

        [Required]
        public int AddresstypeID { get; set; }

        [Required]
        public int PostalCodeID { get; set; }

        [Required]
        public int SuburbID { get; set; }
        public virtual  AddressType  AddressType { get; set; }
        public virtual PostalCode  PostalCode { get; set; }
        public virtual Suburb Suburb { get; set; }
        public virtual ICollection<Learner> learner { get; set; }
        public virtual ICollection<Teacher> Teacher { get; set; }

    }
}
