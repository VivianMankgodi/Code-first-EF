namespace DVT.SchoolLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        HouseNumber = c.String(nullable: false),
                        UnitNo = c.String(nullable: false),
                        AddressTypeId = c.Int(nullable: false),
                        SuburbId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AddressId)
                .ForeignKey("dbo.AddressTypes", t => t.AddressTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Suburbs", t => t.SuburbId, cascadeDelete: true)
                .Index(t => t.AddressTypeId)
                .Index(t => t.SuburbId);
            
            CreateTable(
                "dbo.AddressTypes",
                c => new
                    {
                        AddressTypeId = c.Int(nullable: false, identity: true),
                        TypeName = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AddressTypeId);
            
            CreateTable(
                "dbo.Learners",
                c => new
                    {
                        LearnerId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(nullable: false, maxLength: 100),
                        IdentityDocument = c.Binary(),
                        PasswordHash = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false, maxLength: 10),
                        GenderId = c.Int(nullable: false),
                        UserTypeId = c.Int(nullable: false),
                        IsApproved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.LearnerId)
                .ForeignKey("dbo.Genders", t => t.GenderId, cascadeDelete: true)
                .ForeignKey("dbo.UserTypes", t => t.UserTypeId, cascadeDelete: true)
                .Index(t => t.GenderId)
                .Index(t => t.UserTypeId);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        GenderId = c.Int(nullable: false, identity: true),
                        GenderType = c.String(maxLength: 6),
                    })
                .PrimaryKey(t => t.GenderId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(nullable: false, maxLength: 100),
                        IdentityDocument = c.Binary(),
                        PasswordHash = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false, maxLength: 10),
                        GenderId = c.Int(nullable: false),
                        UserTypeId = c.Int(nullable: false),
                        Standard_TeacherId = c.Int(),
                        Standard_SubjectId = c.Int(),
                    })
                .PrimaryKey(t => t.TeacherId)
                .ForeignKey("dbo.Genders", t => t.GenderId, cascadeDelete: true)
                .ForeignKey("dbo.Standards", t => new { t.Standard_TeacherId, t.Standard_SubjectId })
                .ForeignKey("dbo.UserTypes", t => t.UserTypeId, cascadeDelete: true)
                .Index(t => t.GenderId)
                .Index(t => t.UserTypeId)
                .Index(t => new { t.Standard_TeacherId, t.Standard_SubjectId });
            
            CreateTable(
                "dbo.Standards",
                c => new
                    {
                        TeacherId = c.Int(nullable: false),
                        SubjectId = c.Int(nullable: false),
                        StandardId = c.Int(nullable: false),
                        StandardName = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => new { t.TeacherId, t.SubjectId })
                .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.TeacherId)
                .Index(t => t.SubjectId);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        SubjectId = c.Int(nullable: false, identity: true),
                        SubjectCode = c.String(),
                        SubjectName = c.String(maxLength: 100),
                        SubjectDescription = c.String(),
                        Standard_TeacherId = c.Int(),
                        Standard_SubjectId = c.Int(),
                    })
                .PrimaryKey(t => t.SubjectId)
                .ForeignKey("dbo.Standards", t => new { t.Standard_TeacherId, t.Standard_SubjectId })
                .Index(t => new { t.Standard_TeacherId, t.Standard_SubjectId });
            
            CreateTable(
                "dbo.UserTypes",
                c => new
                    {
                        UserTypeId = c.Int(nullable: false, identity: true),
                        TypeName = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.UserTypeId);
            
            CreateTable(
                "dbo.Suburbs",
                c => new
                    {
                        SuburbId = c.Int(nullable: false, identity: true),
                        SuburbName = c.String(),
                        CityId = c.Int(nullable: false),
                        PostalCodeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SuburbId)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .ForeignKey("dbo.PostalCodes", t => t.PostalCodeId, cascadeDelete: true)
                .Index(t => t.CityId)
                .Index(t => t.PostalCodeId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                        ProvinceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CityId)
                .ForeignKey("dbo.Provinces", t => t.ProvinceId, cascadeDelete: true)
                .Index(t => t.ProvinceId);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        ProvinceId = c.Int(nullable: false, identity: true),
                        ProvinceName = c.String(),
                    })
                .PrimaryKey(t => t.ProvinceId);
            
            CreateTable(
                "dbo.PostalCodes",
                c => new
                    {
                        PostalCodeId = c.Int(nullable: false, identity: true),
                        PostalCodeNumber = c.String(maxLength: 4),
                    })
                .PrimaryKey(t => t.PostalCodeId);
            
            CreateTable(
                "dbo.LearnerAddresses",
                c => new
                    {
                        Learner_LearnerId = c.Int(nullable: false),
                        Address_AddressId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Learner_LearnerId, t.Address_AddressId })
                .ForeignKey("dbo.Learners", t => t.Learner_LearnerId, cascadeDelete: true)
                .ForeignKey("dbo.Addresses", t => t.Address_AddressId, cascadeDelete: true)
                .Index(t => t.Learner_LearnerId)
                .Index(t => t.Address_AddressId);
            
            CreateTable(
                "dbo.TeacherAddresses",
                c => new
                    {
                        Teacher_TeacherId = c.Int(nullable: false),
                        Address_AddressId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Teacher_TeacherId, t.Address_AddressId })
                .ForeignKey("dbo.Teachers", t => t.Teacher_TeacherId, cascadeDelete: true)
                .ForeignKey("dbo.Addresses", t => t.Address_AddressId, cascadeDelete: true)
                .Index(t => t.Teacher_TeacherId)
                .Index(t => t.Address_AddressId);
            
            CreateTable(
                "dbo.SubjectLearners",
                c => new
                    {
                        Subject_SubjectId = c.Int(nullable: false),
                        Learner_LearnerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Subject_SubjectId, t.Learner_LearnerId })
                .ForeignKey("dbo.Subjects", t => t.Subject_SubjectId, cascadeDelete: true)
                .ForeignKey("dbo.Learners", t => t.Learner_LearnerId, cascadeDelete: true)
                .Index(t => t.Subject_SubjectId)
                .Index(t => t.Learner_LearnerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Suburbs", "PostalCodeId", "dbo.PostalCodes");
            DropForeignKey("dbo.Suburbs", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Cities", "ProvinceId", "dbo.Provinces");
            DropForeignKey("dbo.Addresses", "SuburbId", "dbo.Suburbs");
            DropForeignKey("dbo.Teachers", "UserTypeId", "dbo.UserTypes");
            DropForeignKey("dbo.Learners", "UserTypeId", "dbo.UserTypes");
            DropForeignKey("dbo.Standards", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Teachers", new[] { "Standard_TeacherId", "Standard_SubjectId" }, "dbo.Standards");
            DropForeignKey("dbo.Subjects", new[] { "Standard_TeacherId", "Standard_SubjectId" }, "dbo.Standards");
            DropForeignKey("dbo.SubjectLearners", "Learner_LearnerId", "dbo.Learners");
            DropForeignKey("dbo.SubjectLearners", "Subject_SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.Standards", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.Teachers", "GenderId", "dbo.Genders");
            DropForeignKey("dbo.TeacherAddresses", "Address_AddressId", "dbo.Addresses");
            DropForeignKey("dbo.TeacherAddresses", "Teacher_TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Learners", "GenderId", "dbo.Genders");
            DropForeignKey("dbo.LearnerAddresses", "Address_AddressId", "dbo.Addresses");
            DropForeignKey("dbo.LearnerAddresses", "Learner_LearnerId", "dbo.Learners");
            DropForeignKey("dbo.Addresses", "AddressTypeId", "dbo.AddressTypes");
            DropIndex("dbo.SubjectLearners", new[] { "Learner_LearnerId" });
            DropIndex("dbo.SubjectLearners", new[] { "Subject_SubjectId" });
            DropIndex("dbo.TeacherAddresses", new[] { "Address_AddressId" });
            DropIndex("dbo.TeacherAddresses", new[] { "Teacher_TeacherId" });
            DropIndex("dbo.LearnerAddresses", new[] { "Address_AddressId" });
            DropIndex("dbo.LearnerAddresses", new[] { "Learner_LearnerId" });
            DropIndex("dbo.Cities", new[] { "ProvinceId" });
            DropIndex("dbo.Suburbs", new[] { "PostalCodeId" });
            DropIndex("dbo.Suburbs", new[] { "CityId" });
            DropIndex("dbo.Subjects", new[] { "Standard_TeacherId", "Standard_SubjectId" });
            DropIndex("dbo.Standards", new[] { "SubjectId" });
            DropIndex("dbo.Standards", new[] { "TeacherId" });
            DropIndex("dbo.Teachers", new[] { "Standard_TeacherId", "Standard_SubjectId" });
            DropIndex("dbo.Teachers", new[] { "UserTypeId" });
            DropIndex("dbo.Teachers", new[] { "GenderId" });
            DropIndex("dbo.Learners", new[] { "UserTypeId" });
            DropIndex("dbo.Learners", new[] { "GenderId" });
            DropIndex("dbo.Addresses", new[] { "SuburbId" });
            DropIndex("dbo.Addresses", new[] { "AddressTypeId" });
            DropTable("dbo.SubjectLearners");
            DropTable("dbo.TeacherAddresses");
            DropTable("dbo.LearnerAddresses");
            DropTable("dbo.PostalCodes");
            DropTable("dbo.Provinces");
            DropTable("dbo.Cities");
            DropTable("dbo.Suburbs");
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
