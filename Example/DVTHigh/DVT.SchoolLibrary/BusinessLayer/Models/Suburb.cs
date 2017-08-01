using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVT.SchoolLibrary.BusinessLayer.Models
{
  public   class Suburb
    {
        public int SuburbId { get; set; }
        public string SuburbName { get; set; }
        public int CityId { get; set; }

        public int PostalCodeId { get; set; }

        [ForeignKey("CityId")]
        public virtual City City { get; set; }

        [ForeignKey("PostalCodeId")]
        public virtual PostalCode  PostalCode  { get; set; }              
        public virtual ICollection<Address> Address { get; set; }

    }
}
