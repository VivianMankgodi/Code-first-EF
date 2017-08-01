using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVT.SchoolLibrary.Models
{
   public  class City
    {
        public int CityID { get; set; }
        public string CityName { get; set; }
        public int ProvinceID { get; set; }
        public virtual ICollection<Suburb>  Suburb { get; set; }
        public virtual Province Province { get; set; }
    }
}
