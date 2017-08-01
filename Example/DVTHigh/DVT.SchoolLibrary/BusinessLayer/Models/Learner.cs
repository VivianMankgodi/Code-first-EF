using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;

namespace DVT.SchoolLibrary.BusinessLayer.Models
{
    public class Learner       
    {//Data Annotation is part of validation


        //hashing the password
       // public abstract class SHA256 : HashAlgorithm 
        public Learner()        {

        }
        public Learner(string firsnname, string lastname, string passwordhash, string email, string phonenumber, int genderid, int userTypeid, bool isapproved)
        {
            FirstName = firsnname;
            LastName = lastname;
            PasswordHash = passwordhash;
            PhoneNumber = phonenumber;
            GenderId = genderid;
            UserTypeId = userTypeid;
            IsApproved = isapproved;
            
        }


        public int LearnerId { get; set; }

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
        public int GenderId { get; set; }

        [Required]
        public int UserTypeId { get; set; }

        public bool IsApproved { get; set; }

        [ForeignKey("GenderId")]
        public virtual Gender Gender { get; set; }

        [ForeignKey("UserTypeId")]
        public virtual UserType UserType { get; set; }

        //this is many to many student can learn more subject and more subject can be learned by many students
        public virtual ICollection<Subject> Subject { get; set; }
        public virtual ICollection<Address> Address { get; set; }



    }
}
