namespace DLL.Methods.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initials56 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StudentInfo", "PhoneNumber", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            DropColumn("dbo.StudentInfo", "PhoneNumber");
        }
    }
}
