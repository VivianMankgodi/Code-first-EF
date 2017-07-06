namespace DLL.Methods.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createInitial3 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.StudentInfo", name: "Name", newName: "StudentName");
            AlterColumn("dbo.StudentInfo", "StudentName", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StudentInfo", "StudentName", c => c.String(storeType: "ntext"));
            RenameColumn(table: "dbo.StudentInfo", name: "StudentName", newName: "Name");
        }
    }
}
