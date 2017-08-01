using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DVT.SchoolLibrary.Models
{
  public   class AddressType
    {
        public int AddresstypeID { get; set; }

        [StringLength (20)]
        public string TypeName { get; set; }

        //here say Icollection of Address because Address class will be the one that collect PKs here as FKs
        public virtual ICollection<Address> Address { get; set; }
    }
}
