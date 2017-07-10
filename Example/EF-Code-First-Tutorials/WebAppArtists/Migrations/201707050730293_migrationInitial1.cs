namespace WebAppArtists.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrationInitial1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        AlbumID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        artist_ArtistID = c.Int(),
                    })
                .PrimaryKey(t => t.AlbumID)
                .ForeignKey("dbo.Artists", t => t.artist_ArtistID)
                .Index(t => t.artist_ArtistID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Albums", "artist_ArtistID", "dbo.Artists");
            DropIndex("dbo.Albums", new[] { "artist_ArtistID" });
            DropTable("dbo.Albums");
        }
    }
}
