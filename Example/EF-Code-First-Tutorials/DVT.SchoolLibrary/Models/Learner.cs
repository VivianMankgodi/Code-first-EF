using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DVT.SchoolLibrary.Repositories;

namespace DVT.SchoolLibrary.Models
{
 public    class Learner
    {//Data Annotation is part of validation

        public int LearnerID { get; set; }
        [StringLength(100)]
        //Concurrency Check used to handle conflicts that results when multiple users are updating (or deleting) the table at the same time. You can add Data Annotation ConcurrencyCheck attribute on any property, which you want to participate in the Concurrency Check
        [ConcurrencyCheck ]
        [Required]
        public string FirstName { get; set; }

        [StringLength(100)]
        [Required]
        public string LastName { get; set; }
        public byte[] IdentityDocument { get; set; }

        [Required]
        public string PasswordHash { get; set; }
        //here i will use notMapped annotation so that we can have this in the out put but not in the DB's table
        [Column("Confirm password")]
        [NotMapped ]
        [Required ]
        public string ConfirmPasswordHash { get; set; }


        [Required ]
        public string Email { get; set; }
        [NotMapped ]
        [Required ]
        [Column("Confirm Email")]
        public string  ConfirmEmail { get; set; }

        [StringLength(10)]
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public int GenderID { get; set; }

        [Required]
        public int UserTypeID { get; set; }

        [Required]
        public bool IsApproved { get; set; }
        public virtual Gender gender { get; set; }
        public virtual UserType UserType { get; set; }

        //this is many to many student can learn more subject and more subject can be learned by many students
        public virtual ICollection<Subject> Subject { get; set; }
        public virtual ICollection<Address> Address { get; set; }

       

    }
}
