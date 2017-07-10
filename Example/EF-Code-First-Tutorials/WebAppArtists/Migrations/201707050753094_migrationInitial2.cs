namespace WebAppArtists.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrationInitial2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Albums", name: "artist_ArtistID", newName: "artists_ArtistID");
            RenameIndex(table: "dbo.Albums", name: "IX_artist_ArtistID", newName: "IX_artists_ArtistID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Albums", name: "IX_artists_ArtistID", newName: "IX_artist_ArtistID");
            RenameColumn(table: "dbo.Albums", name: "artists_ArtistID", newName: "artist_ArtistID");
        }
    }
}
