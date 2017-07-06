namespace DLL.Methods.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createInitial1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.StudentInfo", name: "gender_genderID", newName: "Genders_genderID");
            RenameIndex(table: "dbo.StudentInfo", name: "IX_gender_genderID", newName: "IX_Genders_genderID");
            AddColumn("dbo.StudentInfo", "Gender", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.StudentInfo", "Gender");
            RenameIndex(table: "dbo.StudentInfo", name: "IX_Genders_genderID", newName: "IX_gender_genderID");
            RenameColumn(table: "dbo.StudentInfo", name: "Genders_genderID", newName: "gender_genderID");
        }
    }
}
