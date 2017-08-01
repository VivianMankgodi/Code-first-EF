namespace DVT.SchoolLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataannottion : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Addresses", "AddresstypeID", "dbo.AddressTypes");
            DropForeignKey("dbo.Addresses", "PostalCodeID", "dbo.PostalCodes");
            DropForeignKey("dbo.Addresses", "SuburbID", "dbo.Suburbs");
            DropForeignKey("dbo.Learners", "GenderID", "dbo.Genders");
            DropForeignKey("dbo.Learners", "UserTypeID", "dbo.UserTypes");
            DropForeignKey("dbo.Teachers", "GenderID", "dbo.Genders");
            DropForeignKey("dbo.Teachers", "UserTypeID", "dbo.UserTypes");
            DropIndex("dbo.Addresses", new[] { "AddresstypeID" });
            DropIndex("dbo.Addresses", new[] { "PostalCodeID" });
            DropIndex("dbo.Addresses", new[] { "SuburbID" });
            DropIndex("dbo.Learners", new[] { "GenderID" });
            DropIndex("dbo.Learners", new[] { "UserTypeID" });
            DropIndex("dbo.Teachers", new[] { "GenderID" });
            DropIndex("dbo.Teachers", new[] { "UserTypeID" });
            AddColumn("dbo.Learners", "IsApproved", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Addresses", "HouseNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Addresses", "UnitNo", c => c.String(nullable: false));
            AlterColumn("dbo.Addresses", "AddresstypeID", c => c.Int(nullable: false));
            AlterColumn("dbo.Addresses", "PostalCodeID", c => c.Int(nullable: false));
            AlterColumn("dbo.Addresses", "SuburbID", c => c.Int(nullable: false));
            AlterColumn("dbo.Learners", "FirstName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Learners", "LastName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Learners", "PasswordHash", c => c.String(nullable: false));
            AlterColumn("dbo.Learners", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Learners", "PhoneNumber", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Learners", "GenderID", c => c.Int(nullable: false));
            AlterColumn("dbo.Learners", "UserTypeID", c => c.Int(nullable: false));
            AlterColumn("dbo.Teachers", "FirstName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Teachers", "LastName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Teachers", "PasswordHash", c => c.String(nullable: false));
            AlterColumn("dbo.Teachers", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Teachers", "PhoneNumber", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Teachers", "GenderID", c => c.Int(nullable: false));
            AlterColumn("dbo.Teachers", "UserTypeID", c => c.Int(nullable: false));
            CreateIndex("dbo.Addresses", "AddresstypeID");
            CreateIndex("dbo.Addresses", "PostalCodeID");
            CreateIndex("dbo.Addresses", "SuburbID");
            CreateIndex("dbo.Learners", "GenderID");
            CreateIndex("dbo.Learners", "UserTypeID");
            CreateIndex("dbo.Teachers", "GenderID");
            CreateIndex("dbo.Teachers", "UserTypeID");
            AddForeignKey("dbo.Addresses", "AddresstypeID", "dbo.AddressTypes", "AddresstypeID", cascadeDelete: true);
            AddForeignKey("dbo.Addresses", "PostalCodeID", "dbo.PostalCodes", "PostalCodeID", cascadeDelete: true);
            AddForeignKey("dbo.Addresses", "SuburbID", "dbo.Suburbs", "SuburbID", cascadeDelete: true);
            AddForeignKey("dbo.Learners", "GenderID", "dbo.Genders", "GenderID", cascadeDelete: true);
            AddForeignKey("dbo.Learners", "UserTypeID", "dbo.UserTypes", "UserTypeID", cascadeDelete: true);
            AddForeignKey("dbo.Teachers", "GenderID", "dbo.Genders", "GenderID", cascadeDelete: true);
            AddForeignKey("dbo.Teachers", "UserTypeID", "dbo.UserTypes", "UserTypeID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "UserTypeID", "dbo.UserTypes");
            DropForeignKey("dbo.Teachers", "GenderID", "dbo.Genders");
            DropForeignKey("dbo.Learners", "UserTypeID", "dbo.UserTypes");
            DropForeignKey("dbo.Learners", "GenderID", "dbo.Genders");
            DropForeignKey("dbo.Addresses", "SuburbID", "dbo.Suburbs");
            DropForeignKey("dbo.Addresses", "PostalCodeID", "dbo.PostalCodes");
            DropForeignKey("dbo.Addresses", "AddresstypeID", "dbo.AddressTypes");
            DropIndex("dbo.Teachers", new[] { "UserTypeID" });
            DropIndex("dbo.Teachers", new[] { "GenderID" });
            DropIndex("dbo.Learners", new[] { "UserTypeID" });
            DropIndex("dbo.Learners", new[] { "GenderID" });
            DropIndex("dbo.Addresses", new[] { "SuburbID" });
            DropIndex("dbo.Addresses", new[] { "PostalCodeID" });
            DropIndex("dbo.Addresses", new[] { "AddresstypeID" });
            AlterColumn("dbo.Teachers", "UserTypeID", c => c.Int());
            AlterColumn("dbo.Teachers", "GenderID", c => c.Int());
            AlterColumn("dbo.Teachers", "PhoneNumber", c => c.String(maxLength: 10));
            AlterColumn("dbo.Teachers", "Email", c => c.String());
            AlterColumn("dbo.Teachers", "PasswordHash", c => c.String());
            AlterColumn("dbo.Teachers", "LastName", c => c.String(maxLength: 100));
            AlterColumn("dbo.Teachers", "FirstName", c => c.String(maxLength: 100));
            AlterColumn("dbo.Learners", "UserTypeID", c => c.Int());
            AlterColumn("dbo.Learners", "GenderID", c => c.Int());
            AlterColumn("dbo.Learners", "PhoneNumber", c => c.String(maxLength: 10));
            AlterColumn("dbo.Learners", "Email", c => c.String());
            AlterColumn("dbo.Learners", "PasswordHash", c => c.String());
            AlterColumn("dbo.Learners", "LastName", c => c.String(maxLength: 100));
            AlterColumn("dbo.Learners", "FirstName", c => c.String(maxLength: 100));
            AlterColumn("dbo.Addresses", "SuburbID", c => c.Int());
            AlterColumn("dbo.Addresses", "PostalCodeID", c => c.Int());
            AlterColumn("dbo.Addresses", "AddresstypeID", c => c.Int());
            AlterColumn("dbo.Addresses", "UnitNo", c => c.String());
            AlterColumn("dbo.Addresses", "HouseNumber", c => c.String());
            DropColumn("dbo.Learners", "IsApproved");
            CreateIndex("dbo.Teachers", "UserTypeID");
            CreateIndex("dbo.Teachers", "GenderID");
            CreateIndex("dbo.Learners", "UserTypeID");
            CreateIndex("dbo.Learners", "GenderID");
            CreateIndex("dbo.Addresses", "SuburbID");
            CreateIndex("dbo.Addresses", "PostalCodeID");
            CreateIndex("dbo.Addresses", "AddresstypeID");
            AddForeignKey("dbo.Teachers", "UserTypeID", "dbo.UserTypes", "UserTypeID");
            AddForeignKey("dbo.Teachers", "GenderID", "dbo.Genders", "GenderID");
            AddForeignKey("dbo.Learners", "UserTypeID", "dbo.UserTypes", "UserTypeID");
            AddForeignKey("dbo.Learners", "GenderID", "dbo.Genders", "GenderID");
            AddForeignKey("dbo.Addresses", "SuburbID", "dbo.Suburbs", "SuburbID");
            AddForeignKey("dbo.Addresses", "PostalCodeID", "dbo.PostalCodes", "PostalCodeID");
            AddForeignKey("dbo.Addresses", "AddresstypeID", "dbo.AddressTypes", "AddresstypeID");
        }
    }
}
