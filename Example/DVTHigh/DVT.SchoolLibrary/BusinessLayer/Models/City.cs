using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVT.SchoolLibrary.BusinessLayer.Models
{
   public  class City
    {
        public int CityId { get; set; }

        public string CityName { get; set; }

        public int ProvinceId { get; set; }

        [ForeignKey("ProvinceId")]
        public virtual Province Province { get; set; }

        public virtual ICollection<Suburb>  Suburb { get; set; }

        
    }
}
