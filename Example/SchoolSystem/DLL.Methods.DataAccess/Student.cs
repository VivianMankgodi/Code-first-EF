using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DLL.Methods.DataAccess
{
    [Table("StudentInfo")]
  public   class Student
    {
        //here is the constructr method
        public Student()
        { }
        /*
        Using Data Annotation  we use them for class and even for a propertie  and they are types of Data Annotation
        e.g of data annotation
            [Data Annotion]
            public int propertyname{get; set;}
            */
        /* decaring Scalar properties*/
        //here we will create properties for Student Class(Table)
        //With code-frist a property that include the word ID/id it takes it as PK and if the property data type is numeric like int or GUID it will make the PK to be Identity(Adding primary keys automatically). If you want to define StdId as primary key then you have to use DataAnnotations or Fluent API to configure it as primary key. We will see how to do it later in these tutorials.
        [Key]
        public int StudentID { get; set; }

        [Column("Name", TypeName ="ntext")]
        [MaxLength(20)]
        public string StudentName { get; set; }

        [NotMapped]
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }


        /* Declaring Navigation Properties*/
        //here show that Standard will be a foreign key in here
        public Nullable<int> StandardID { get; set; }//foreign key, here we must specify it as Nullable so that it can be null
        [ForeignKey("StandardID")]
        public virtual Standard standard { get; set; }

        //this class it is DERVED Class and the context class only include Base Classes as DbSet
        public Nullable<int> TeacherID { get; set; }//foreign key
        public Teacher teacher { get; set; }//this Class is the foreign key in the this class but we din't include it in the DbContext class but it will be there in the Database becuase it is a foreign in the Student class(Table) 

    }
}
