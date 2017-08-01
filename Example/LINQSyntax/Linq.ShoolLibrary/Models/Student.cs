using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.ShoolLibrary.Models
{
   public  class Student
    {
        public int StudentID { get; set; }


        [MaxLength(20)]
        public string StudentName { get; set; }


        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public Nullable<int> GenderID { get; set; }

        /* Declaring Navigation Properties*/
        //here show that Standard will be a foreign key in here
        public Gender Gender { get; set; } //this class it is DERVED Class and the context class only include Base Classes as DbSet//this Class is the foreign key in the this class but we din't include it in the DbContext class but it will be there in the Database becuase it is a foreign in the Student class(Table) 
        public Nullable<int> StandardID { get; set; }//foreign key, here we must specify it as Nullable so that it can be null
        [ForeignKey("StandardID")]
        public virtual Standard standard { get; set; }

        public Nullable<int> TeacherID { get; set; }//foreign key
        public virtual Teacher teacher { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
