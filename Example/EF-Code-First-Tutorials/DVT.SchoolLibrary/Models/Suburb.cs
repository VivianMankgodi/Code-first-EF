using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVT.SchoolLibrary.Models
{
  public   class Suburb
    {
        public int SuburbID { get; set; }
        public string SuburbName { get; set; }
        public Nullable<int> CityID { get; set; }
        public City City { get; set; }
        public virtual ICollection<Address> Address { get; set; }
    }
}
