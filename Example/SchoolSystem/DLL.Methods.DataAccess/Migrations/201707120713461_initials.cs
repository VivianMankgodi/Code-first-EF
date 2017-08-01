namespace DLL.Methods.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initials : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false),
                        CourseName = c.String(),
                    })
                .PrimaryKey(t => t.CourseId);
            
            CreateTable(
                "dbo.StudentInfo",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        StudentName = c.String(maxLength: 20),
                        DateOfBirth = c.DateTime(),
                        Photo = c.Binary(),
                        Height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Single(nullable: false),
                        GenderID = c.Int(),
                        StandardID = c.Int(),
                        TeacherID = c.Int(),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.Genders", t => t.GenderID)
                .ForeignKey("dbo.Standards", t => t.StandardID)
                .ForeignKey("dbo.Teachers", t => t.TeacherID)
                .Index(t => t.GenderID)
                .Index(t => t.StandardID)
                .Index(t => t.TeacherID);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        genderID = c.Int(nullable: false, identity: true),
                        GenderType = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.genderID);
            
            CreateTable(
                "dbo.Standards",
                c => new
                    {
                        StandardID = c.Int(nullable: false, identity: true),
                        Standardname = c.String(),
                    })
                .PrimaryKey(t => t.StandardID);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherID = c.Int(nullable: false, identity: true),
                        TeacherName = c.String(),
                        Surname = c.String(),
                    })
                .PrimaryKey(t => t.TeacherID);
            
            CreateTable(
                "dbo.StudentCourses",
                c => new
                    {
                        Student_StudentID = c.Int(nullable: false),
                        Course_CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_StudentID, t.Course_CourseId })
                .ForeignKey("dbo.StudentInfo", t => t.Student_StudentID, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_CourseId, cascadeDelete: true)
                .Index(t => t.Student_StudentID)
                .Index(t => t.Course_CourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentInfo", "TeacherID", "dbo.Teachers");
            DropForeignKey("dbo.StudentInfo", "StandardID", "dbo.Standards");
            DropForeignKey("dbo.StudentInfo", "GenderID", "dbo.Genders");
            DropForeignKey("dbo.StudentCourses", "Course_CourseId", "dbo.Courses");
            DropForeignKey("dbo.StudentCourses", "Student_StudentID", "dbo.StudentInfo");
            DropIndex("dbo.StudentCourses", new[] { "Course_CourseId" });
            DropIndex("dbo.StudentCourses", new[] { "Student_StudentID" });
            DropIndex("dbo.StudentInfo", new[] { "TeacherID" });
            DropIndex("dbo.StudentInfo", new[] { "StandardID" });
            DropIndex("dbo.StudentInfo", new[] { "GenderID" });
            DropTable("dbo.StudentCourses");
            DropTable("dbo.Teachers");
            DropTable("dbo.Standards");
            DropTable("dbo.Genders");
            DropTable("dbo.StudentInfo");
            DropTable("dbo.Courses");
        }
    }
}
