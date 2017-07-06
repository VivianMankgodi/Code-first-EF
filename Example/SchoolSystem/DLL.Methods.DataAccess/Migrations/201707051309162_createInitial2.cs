namespace DLL.Methods.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createInitial2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.StudentInfo", name: "Genders_genderID", newName: "GenderID");
            RenameIndex(table: "dbo.StudentInfo", name: "IX_Genders_genderID", newName: "IX_GenderID");
            DropColumn("dbo.StudentInfo", "Gender");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StudentInfo", "Gender", c => c.Int());
            RenameIndex(table: "dbo.StudentInfo", name: "IX_GenderID", newName: "IX_Genders_genderID");
            RenameColumn(table: "dbo.StudentInfo", name: "GenderID", newName: "Genders_genderID");
        }
    }
}
