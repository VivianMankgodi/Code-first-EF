namespace DVT.SchoolLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intilas2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AddressTypes", "TypeName", c => c.String(maxLength: 20));
            AlterColumn("dbo.Learners", "FirstName", c => c.String(maxLength: 100));
            AlterColumn("dbo.Learners", "LastName", c => c.String(maxLength: 100));
            AlterColumn("dbo.Learners", "PhoneNumber", c => c.String(maxLength: 10));
            AlterColumn("dbo.Genders", "Type", c => c.String(maxLength: 6));
            AlterColumn("dbo.Teachers", "FirstName", c => c.String(maxLength: 100));
            AlterColumn("dbo.Teachers", "LastName", c => c.String(maxLength: 100));
            AlterColumn("dbo.Teachers", "PhoneNumber", c => c.String(maxLength: 10));
            AlterColumn("dbo.Standards", "StandardName", c => c.String(maxLength: 10));
            AlterColumn("dbo.Subjects", "SubjectName", c => c.String(maxLength: 100));
            AlterColumn("dbo.UserTypes", "TypeName", c => c.String(maxLength: 20));
            AlterColumn("dbo.PostalCodes", "PostalCodeNumber", c => c.String(maxLength: 4));
            DropColumn("dbo.Subjects", "SubjectCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Subjects", "SubjectCode", c => c.String());
            AlterColumn("dbo.PostalCodes", "PostalCodeNumber", c => c.String());
            AlterColumn("dbo.UserTypes", "TypeName", c => c.String());
            AlterColumn("dbo.Subjects", "SubjectName", c => c.String());
            AlterColumn("dbo.Standards", "StandardName", c => c.String());
            AlterColumn("dbo.Teachers", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Teachers", "LastName", c => c.String());
            AlterColumn("dbo.Teachers", "FirstName", c => c.String());
            AlterColumn("dbo.Genders", "Type", c => c.String());
            AlterColumn("dbo.Learners", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Learners", "LastName", c => c.String());
            AlterColumn("dbo.Learners", "FirstName", c => c.String());
            AlterColumn("dbo.AddressTypes", "TypeName", c => c.String());
        }
    }
}
