using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Methods.DataAccess
{
  public   class Gender
    {
        public int genderID { get; set; }
        [Required]
        [StringLength(20)]
        public string GenderType { get; set; }
    }
}
