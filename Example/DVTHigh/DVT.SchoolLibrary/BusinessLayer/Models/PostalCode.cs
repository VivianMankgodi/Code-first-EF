using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DVT.SchoolLibrary.BusinessLayer.Models
{
   public  class PostalCode
    {
        public int PostalCodeId { get; set; }

        [StringLength(4)]
        public string PostalCodeNumber { get; set; }

       public virtual ICollection<Suburb> Suburb { get; set; }
    }
}
