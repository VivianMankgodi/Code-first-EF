namespace WebAppArtists.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreating : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ArtistDetails",
                c => new
                    {
                        ArtistID = c.Int(nullable: false),
                        Bio = c.String(),
                    })
                .PrimaryKey(t => t.ArtistID)
                .ForeignKey("dbo.Artists", t => t.ArtistID)
                .Index(t => t.ArtistID);
            
            DropColumn("dbo.Artists", "Bio");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Artists", "Bio", c => c.String());
            DropForeignKey("dbo.ArtistDetails", "ArtistID", "dbo.Artists");
            DropIndex("dbo.ArtistDetails", new[] { "ArtistID" });
            DropTable("dbo.ArtistDetails");
        }
    }
}
