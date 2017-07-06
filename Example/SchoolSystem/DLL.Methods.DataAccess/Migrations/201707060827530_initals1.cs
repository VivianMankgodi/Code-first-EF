namespace DLL.Methods.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initals1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StudentInfo", "DateOfBirth", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.StudentInfo", "DateOfBirth");
        }
    }
}
