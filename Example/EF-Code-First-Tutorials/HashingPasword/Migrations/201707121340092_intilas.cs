namespace DVT.SchoolLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intilas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressID = c.Int(nullable: false, identity: true),
                        HouseNumber = c.String(),
                        UnitNo = c.String(),
                        AddresstypeID = c.Int(nullable: false),
                        PostalCodeID = c.Int(nullable: false),
                        SuburbID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AddressID)
                .ForeignKey("dbo.AddressTypes", t => t.AddresstypeID, cascadeDelete: true)
                .ForeignKey("dbo.PostalCodes", t => t.PostalCodeID, cascadeDelete: true)
                .ForeignKey("dbo.Suburbs", t => t.SuburbID, cascadeDelete: true)
                .Index(t => t.AddresstypeID)
                .Index(t => t.PostalCodeID)
                .Index(t => t.SuburbID);
            
            CreateTable(
                "dbo.AddressTypes",
                c => new
                    {
                        AddresstypeID = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.AddresstypeID);
            
            CreateTable(
                "dbo.Learners",
                c => new
                    {
                        LearnerID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        IdentityDocument = c.Binary(),
                        PasswordHash = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        GenderID = c.Int(nullable: false),
                        UserTypeID = c.Int(nullable: false),
                        Standard_TeacherID = c.Int(),
                        Standard_SubjectID = c.Int(),
                    })
                .PrimaryKey(t => t.LearnerID)
                .ForeignKey("dbo.Genders", t => t.GenderID, cascadeDelete: true)
                .ForeignKey("dbo.Standards", t => new { t.Standard_TeacherID, t.Standard_SubjectID })
                .ForeignKey("dbo.UserTypes", t => t.UserTypeID, cascadeDelete: true)
                .Index(t => t.GenderID)
                .Index(t => t.UserTypeID)
                .Index(t => new { t.Standard_TeacherID, t.Standard_SubjectID });
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        GenderID = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.GenderID);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        IdentityDocument = c.Binary(),
                        PasswordHash = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        GenderID = c.Int(nullable: false),
                        UserTypeID = c.Int(nullable: false),
                        Standard_TeacherID = c.Int(),
                        Standard_SubjectID = c.Int(),
                    })
                .PrimaryKey(t => t.TeacherID)
                .ForeignKey("dbo.Genders", t => t.GenderID, cascadeDelete: true)
                .ForeignKey("dbo.Standards", t => new { t.Standard_TeacherID, t.Standard_SubjectID })
                .ForeignKey("dbo.UserTypes", t => t.UserTypeID, cascadeDelete: true)
                .Index(t => t.GenderID)
                .Index(t => t.UserTypeID)
                .Index(t => new { t.Standard_TeacherID, t.Standard_SubjectID });
            
            CreateTable(
                "dbo.Standards",
                c => new
                    {
                        TeacherID = c.Int(nullable: false),
                        SubjectID = c.Int(nullable: false),
                        StandardName = c.String(),
                    })
                .PrimaryKey(t => new { t.TeacherID, t.SubjectID })
                .ForeignKey("dbo.Subjects", t => t.SubjectID, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.TeacherID, cascadeDelete: true)
                .Index(t => t.TeacherID)
                .Index(t => t.SubjectID);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        SubjectID = c.Int(nullable: false, identity: true),
                        SubjectCode = c.String(),
                        SubjectName = c.String(),
                        SubjectDescription = c.String(),
                        Standard_TeacherID = c.Int(),
                        Standard_SubjectID = c.Int(),
                    })
                .PrimaryKey(t => t.SubjectID)
                .ForeignKey("dbo.Standards", t => new { t.Standard_TeacherID, t.Standard_SubjectID })
                .Index(t => new { t.Standard_TeacherID, t.Standard_SubjectID });
            
            CreateTable(
                "dbo.UserTypes",
                c => new
                    {
                        UserTypeID = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.UserTypeID);
            
            CreateTable(
                "dbo.PostalCodes",
                c => new
                    {
                        PostalCodeID = c.Int(nullable: false, identity: true),
                        PostalCodeNumber = c.String(),
                    })
                .PrimaryKey(t => t.PostalCodeID);
            
            CreateTable(
                "dbo.Suburbs",
                c => new
                    {
                        SuburbID = c.Int(nullable: false, identity: true),
                        SuburbName = c.String(),
                        CityID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SuburbID)
                .ForeignKey("dbo.Cities", t => t.CityID, cascadeDelete: true)
                .Index(t => t.CityID);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityID = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                        ProvinceID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CityID)
                .ForeignKey("dbo.Provinces", t => t.ProvinceID, cascadeDelete: true)
                .Index(t => t.ProvinceID);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        ProvinceID = c.Int(nullable: false, identity: true),
                        ProvinceName = c.String(),
                    })
                .PrimaryKey(t => t.ProvinceID);
            
            CreateTable(
                "dbo.LearnerAddresses",
                c => new
                    {
                        Learner_LearnerID = c.Int(nullable: false),
                        Address_AddressID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Learner_LearnerID, t.Address_AddressID })
                .ForeignKey("dbo.Learners", t => t.Learner_LearnerID, cascadeDelete: true)
                .ForeignKey("dbo.Addresses", t => t.Address_AddressID, cascadeDelete: true)
                .Index(t => t.Learner_LearnerID)
                .Index(t => t.Address_AddressID);
            
            CreateTable(
                "dbo.TeacherAddresses",
                c => new
                    {
                        Teacher_TeacherID = c.Int(nullable: false),
                        Address_AddressID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Teacher_TeacherID, t.Address_AddressID })
                .ForeignKey("dbo.Teachers", t => t.Teacher_TeacherID, cascadeDelete: true)
                .ForeignKey("dbo.Addresses", t => t.Address_AddressID, cascadeDelete: true)
                .Index(t => t.Teacher_TeacherID)
                .Index(t => t.Address_AddressID);
            
            CreateTable(
                "dbo.SubjectLearners",
                c => new
                    {
                        Subject_SubjectID = c.Int(nullable: false),
                        Learner_LearnerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Subject_SubjectID, t.Learner_LearnerID })
                .ForeignKey("dbo.Subjects", t => t.Subject_SubjectID, cascadeDelete: true)
                .ForeignKey("dbo.Learners", t => t.Learner_LearnerID, cascadeDelete: true)
                .Index(t => t.Subject_SubjectID)
                .Index(t => t.Learner_LearnerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Suburbs", "CityID", "dbo.Cities");
            DropForeignKey("dbo.Cities", "ProvinceID", "dbo.Provinces");
            DropForeignKey("dbo.Addresses", "SuburbID", "dbo.Suburbs");
            DropForeignKey("dbo.Addresses", "PostalCodeID", "dbo.PostalCodes");
            DropForeignKey("dbo.Teachers", "UserTypeID", "dbo.UserTypes");
            DropForeignKey("dbo.Learners", "UserTypeID", "dbo.UserTypes");
            DropForeignKey("dbo.Standards", "TeacherID", "dbo.Teachers");
            DropForeignKey("dbo.Teachers", new[] { "Standard_TeacherID", "Standard_SubjectID" }, "dbo.Standards");
            DropForeignKey("dbo.Subjects", new[] { "Standard_TeacherID", "Standard_SubjectID" }, "dbo.Standards");
            DropForeignKey("dbo.SubjectLearners", "Learner_LearnerID", "dbo.Learners");
            DropForeignKey("dbo.SubjectLearners", "Subject_SubjectID", "dbo.Subjects");
            DropForeignKey("dbo.Standards", "SubjectID", "dbo.Subjects");
            DropForeignKey("dbo.Learners", new[] { "Standard_TeacherID", "Standard_SubjectID" }, "dbo.Standards");
            DropForeignKey("dbo.Teachers", "GenderID", "dbo.Genders");
            DropForeignKey("dbo.TeacherAddresses", "Address_AddressID", "dbo.Addresses");
            DropForeignKey("dbo.TeacherAddresses", "Teacher_TeacherID", "dbo.Teachers");
            DropForeignKey("dbo.Learners", "GenderID", "dbo.Genders");
            DropForeignKey("dbo.LearnerAddresses", "Address_AddressID", "dbo.Addresses");
            DropForeignKey("dbo.LearnerAddresses", "Learner_LearnerID", "dbo.Learners");
            DropForeignKey("dbo.Addresses", "AddresstypeID", "dbo.AddressTypes");
            DropIndex("dbo.SubjectLearners", new[] { "Learner_LearnerID" });
            DropIndex("dbo.SubjectLearners", new[] { "Subject_SubjectID" });
            DropIndex("dbo.TeacherAddresses", new[] { "Address_AddressID" });
            DropIndex("dbo.TeacherAddresses", new[] { "Teacher_TeacherID" });
            DropIndex("dbo.LearnerAddresses", new[] { "Address_AddressID" });
            DropIndex("dbo.LearnerAddresses", new[] { "Learner_LearnerID" });
            DropIndex("dbo.Cities", new[] { "ProvinceID" });
            DropIndex("dbo.Suburbs", new[] { "CityID" });
            DropIndex("dbo.Subjects", new[] { "Standard_TeacherID", "Standard_SubjectID" });
            DropIndex("dbo.Standards", new[] { "SubjectID" });
            DropIndex("dbo.Standards", new[] { "TeacherID" });
            DropIndex("dbo.Teachers", new[] { "Standard_TeacherID", "Standard_SubjectID" });
            DropIndex("dbo.Teachers", new[] { "UserTypeID" });
            DropIndex("dbo.Teachers", new[] { "GenderID" });
            DropIndex("dbo.Learners", new[] { "Standard_TeacherID", "Standard_SubjectID" });
            DropIndex("dbo.Learners", new[] { "UserTypeID" });
            DropIndex("dbo.Learners", new[] { "GenderID" });
            DropIndex("dbo.Addresses", new[] { "SuburbID" });
            DropIndex("dbo.Addresses", new[] { "PostalCodeID" });
            DropIndex("dbo.Addresses", new[] { "AddresstypeID" });
            DropTable("dbo.SubjectLearners");
            DropTable("dbo.TeacherAddresses");
            DropTable("dbo.LearnerAddresses");
            DropTable("dbo.Provinces");
            DropTable("dbo.Cities");
            DropTable("dbo.Suburbs");
            DropTable("dbo.PostalCodes");
            DropTable("dbo.UserTypes");
            DropTable("dbo.Subjects");
            DropTable("dbo.Standards");
            DropTable("dbo.Teachers");
            DropTable("dbo.Genders");
            DropTable("dbo.Learners");
            DropTable("dbo.AddressTypes");
            DropTable("dbo.Addresses");
        }
    }
}
