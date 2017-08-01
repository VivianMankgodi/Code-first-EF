namespace DVT.SchoolLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intilas1 : DbMigration
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
            DropForeignKey("dbo.Suburbs", "CityID", "dbo.Cities");
            DropForeignKey("dbo.Cities", "ProvinceID", "dbo.Provinces");
            DropIndex("dbo.Addresses", new[] { "AddresstypeID" });
            DropIndex("dbo.Addresses", new[] { "PostalCodeID" });
            DropIndex("dbo.Addresses", new[] { "SuburbID" });
            DropIndex("dbo.Learners", new[] { "GenderID" });
            DropIndex("dbo.Learners", new[] { "UserTypeID" });
            DropIndex("dbo.Teachers", new[] { "GenderID" });
            DropIndex("dbo.Teachers", new[] { "UserTypeID" });
            DropIndex("dbo.Suburbs", new[] { "CityID" });
            DropIndex("dbo.Cities", new[] { "ProvinceID" });
            AlterColumn("dbo.Addresses", "AddresstypeID", c => c.Int());
            AlterColumn("dbo.Addresses", "PostalCodeID", c => c.Int());
            AlterColumn("dbo.Addresses", "SuburbID", c => c.Int());
            AlterColumn("dbo.Learners", "GenderID", c => c.Int());
            AlterColumn("dbo.Learners", "UserTypeID", c => c.Int());
            AlterColumn("dbo.Teachers", "GenderID", c => c.Int());
            AlterColumn("dbo.Teachers", "UserTypeID", c => c.Int());
            AlterColumn("dbo.Suburbs", "CityID", c => c.Int());
            AlterColumn("dbo.Cities", "ProvinceID", c => c.Int());
            CreateIndex("dbo.Addresses", "AddresstypeID");
            CreateIndex("dbo.Addresses", "PostalCodeID");
            CreateIndex("dbo.Addresses", "SuburbID");
            CreateIndex("dbo.Learners", "GenderID");
            CreateIndex("dbo.Learners", "UserTypeID");
            CreateIndex("dbo.Teachers", "GenderID");
            CreateIndex("dbo.Teachers", "UserTypeID");
            CreateIndex("dbo.Suburbs", "CityID");
            CreateIndex("dbo.Cities", "ProvinceID");
            AddForeignKey("dbo.Addresses", "AddresstypeID", "dbo.AddressTypes", "AddresstypeID");
            AddForeignKey("dbo.Addresses", "PostalCodeID", "dbo.PostalCodes", "PostalCodeID");
            AddForeignKey("dbo.Addresses", "SuburbID", "dbo.Suburbs", "SuburbID");
            AddForeignKey("dbo.Learners", "GenderID", "dbo.Genders", "GenderID");
            AddForeignKey("dbo.Learners", "UserTypeID", "dbo.UserTypes", "UserTypeID");
            AddForeignKey("dbo.Teachers", "GenderID", "dbo.Genders", "GenderID");
            AddForeignKey("dbo.Teachers", "UserTypeID", "dbo.UserTypes", "UserTypeID");
            AddForeignKey("dbo.Suburbs", "CityID", "dbo.Cities", "CityID");
            AddForeignKey("dbo.Cities", "ProvinceID", "dbo.Provinces", "ProvinceID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "ProvinceID", "dbo.Provinces");
            DropForeignKey("dbo.Suburbs", "CityID", "dbo.Cities");
            DropForeignKey("dbo.Teachers", "UserTypeID", "dbo.UserTypes");
            DropForeignKey("dbo.Teachers", "GenderID", "dbo.Genders");
            DropForeignKey("dbo.Learners", "UserTypeID", "dbo.UserTypes");
            DropForeignKey("dbo.Learners", "GenderID", "dbo.Genders");
            DropForeignKey("dbo.Addresses", "SuburbID", "dbo.Suburbs");
            DropForeignKey("dbo.Addresses", "PostalCodeID", "dbo.PostalCodes");
            DropForeignKey("dbo.Addresses", "AddresstypeID", "dbo.AddressTypes");
            DropIndex("dbo.Cities", new[] { "ProvinceID" });
            DropIndex("dbo.Suburbs", new[] { "CityID" });
            DropIndex("dbo.Teachers", new[] { "UserTypeID" });
            DropIndex("dbo.Teachers", new[] { "GenderID" });
            DropIndex("dbo.Learners", new[] { "UserTypeID" });
            DropIndex("dbo.Learners", new[] { "GenderID" });
            DropIndex("dbo.Addresses", new[] { "SuburbID" });
            DropIndex("dbo.Addresses", new[] { "PostalCodeID" });
            DropIndex("dbo.Addresses", new[] { "AddresstypeID" });
            AlterColumn("dbo.Cities", "ProvinceID", c => c.Int(nullable: false));
            AlterColumn("dbo.Suburbs", "CityID", c => c.Int(nullable: false));
            AlterColumn("dbo.Teachers", "UserTypeID", c => c.Int(nullable: false));
            AlterColumn("dbo.Teachers", "GenderID", c => c.Int(nullable: false));
            AlterColumn("dbo.Learners", "UserTypeID", c => c.Int(nullable: false));
            AlterColumn("dbo.Learners", "GenderID", c => c.Int(nullable: false));
            AlterColumn("dbo.Addresses", "SuburbID", c => c.Int(nullable: false));
            AlterColumn("dbo.Addresses", "PostalCodeID", c => c.Int(nullable: false));
            AlterColumn("dbo.Addresses", "AddresstypeID", c => c.Int(nullable: false));
            CreateIndex("dbo.Cities", "ProvinceID");
            CreateIndex("dbo.Suburbs", "CityID");
            CreateIndex("dbo.Teachers", "UserTypeID");
            CreateIndex("dbo.Teachers", "GenderID");
            CreateIndex("dbo.Learners", "UserTypeID");
            CreateIndex("dbo.Learners", "GenderID");
            CreateIndex("dbo.Addresses", "SuburbID");
            CreateIndex("dbo.Addresses", "PostalCodeID");
            CreateIndex("dbo.Addresses", "AddresstypeID");
            AddForeignKey("dbo.Cities", "ProvinceID", "dbo.Provinces", "ProvinceID", cascadeDelete: true);
            AddForeignKey("dbo.Suburbs", "CityID", "dbo.Cities", "CityID", cascadeDelete: true);
            AddForeignKey("dbo.Teachers", "UserTypeID", "dbo.UserTypes", "UserTypeID", cascadeDelete: true);
            AddForeignKey("dbo.Teachers", "GenderID", "dbo.Genders", "GenderID", cascadeDelete: true);
            AddForeignKey("dbo.Learners", "UserTypeID", "dbo.UserTypes", "UserTypeID", cascadeDelete: true);
            AddForeignKey("dbo.Learners", "GenderID", "dbo.Genders", "GenderID", cascadeDelete: true);
            AddForeignKey("dbo.Addresses", "SuburbID", "dbo.Suburbs", "SuburbID", cascadeDelete: true);
            AddForeignKey("dbo.Addresses", "PostalCodeID", "dbo.PostalCodes", "PostalCodeID", cascadeDelete: true);
            AddForeignKey("dbo.Addresses", "AddresstypeID", "dbo.AddressTypes", "AddresstypeID", cascadeDelete: true);
        }
    }
}
