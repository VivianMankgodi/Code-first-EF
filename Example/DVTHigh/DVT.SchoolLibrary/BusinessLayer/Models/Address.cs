using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DVT.SchoolLibrary.BusinessLayer.Models
{
 public   class Address
    {
        public int AddressId { get; set; }
        [Required ]
        public string HouseNumber { get; set; }
        [Required]
        public string UnitNo { get; set; }

        [Required]      
       public int AddressTypeId { get; set; }

        [Required]
   
        public int SuburbId { get; set; }

        [ForeignKey("AddressTypeId")]
        public virtual AddressType AddressType { get; set; }

        [ForeignKey("SuburbId")]
        public virtual Suburb Suburb { get; set; }

        public virtual ICollection<Learner> Learner { get; set; }

        public virtual ICollection<Teacher> Teacher { get; set; }

    }
}
