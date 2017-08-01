using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DVT.SchoolLibrary.BusinessLayer.Models
{
  public   class Teacher
    {
        public int TeacherId { get; set; }

        [StringLength(100)]
        [Required]
        public string FirstName { get; set; }

        [StringLength(100)]
        [Required]
        public string LastName { get; set; }
        public byte[] IdentityDocument { get; set; }

        [Required]
        public string PasswordHash { get; set; }
        [Column("Confirm password")]
        [NotMapped]
        [Required]
        public string ConfirmPasswordHash { get; set; }

        [Required]
        public string Email { get; set; }
        [NotMapped]
        [Required]
        [Column("Confirm Email")]
        public string ConfirmEmail { get; set; }

        [StringLength(10)]
        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public int GenderId { get; set; }

        [Required]
        public int UserTypeId { get; set; }

          //public int SubjectId { get; set; }

        [ForeignKey("GenderId")]
        public virtual Gender Gender { get; set; }

        [ForeignKey("UserTypeId")]
        public virtual UserType UserType { get; set; }

        //a teacher can teach many subject but a subject can be taught by one teacher
     //     public virtual Subject Subject { get; set; }
        //a teache can teach many standard and many standard can be taught by many teachers
       public virtual ICollection<Standard> Standard { get; set; }

       public virtual ICollection<Address> Address { get; set; }

    }
}
