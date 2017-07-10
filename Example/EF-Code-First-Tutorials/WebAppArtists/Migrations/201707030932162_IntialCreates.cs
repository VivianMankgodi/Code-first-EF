namespace WebAppArtists.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialCreates : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Artists", "Name", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Artists", "Name", c => c.String());
        }
    }
}
