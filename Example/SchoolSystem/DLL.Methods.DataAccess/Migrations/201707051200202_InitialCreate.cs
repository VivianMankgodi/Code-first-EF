namespace DLL.Methods.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Standards",
                c => new
                    {
                        StandardID = c.Int(nullable: false, identity: true),
                        Standardname = c.String(),
                    })
                .PrimaryKey(t => t.StandardID);
            
            CreateTable(
                "dbo.StudentInfo",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        Name = c.String(storeType: "ntext"),
                        Photo = c.Binary(),
                        Height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Single(nullable: false),
                        StandardID = c.Int(),
                        TeacherID = c.Int(),
                        gender_genderID = c.Int(),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.Genders", t => t.gender_genderID)
                .ForeignKey("dbo.Standards", t => t.StandardID)
                .ForeignKey("dbo.Teachers", t => t.TeacherID)
                .Index(t => t.StandardID)
                .Index(t => t.TeacherID)
                .Index(t => t.gender_genderID);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        genderID = c.Int(nullable: false, identity: true),
                        GenderType = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.genderID);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherID = c.Int(nullable: false, identity: true),
                        TeacherName = c.String(),
                    })
                .PrimaryKey(t => t.TeacherID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentInfo", "TeacherID", "dbo.Teachers");
            DropForeignKey("dbo.StudentInfo", "StandardID", "dbo.Standards");
            DropForeignKey("dbo.StudentInfo", "gender_genderID", "dbo.Genders");
            DropIndex("dbo.StudentInfo", new[] { "gender_genderID" });
            DropIndex("dbo.StudentInfo", new[] { "TeacherID" });
            DropIndex("dbo.StudentInfo", new[] { "StandardID" });
            DropTable("dbo.Teachers");
            DropTable("dbo.Genders");
            DropTable("dbo.StudentInfo");
            DropTable("dbo.Standards");
        }
    }
}
