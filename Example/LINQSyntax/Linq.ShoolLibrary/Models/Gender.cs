using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.ShoolLibrary.Models
{
    class Gender
    {

        public int genderID { get; set; }
        [Required]
        [StringLength(20)]
        public string GenderType { get; set; }
    }
}
