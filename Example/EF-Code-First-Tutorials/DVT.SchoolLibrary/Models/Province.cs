using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVT.SchoolLibrary.Models
{
  public  class Province
    {
        public int ProvinceID { get; set; }
        public string ProvinceName { get; set; }
        public virtual ICollection<City> City { get; set; }
    }
}
