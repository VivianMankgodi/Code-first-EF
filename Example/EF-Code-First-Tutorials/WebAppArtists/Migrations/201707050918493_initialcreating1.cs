namespace WebAppArtists.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreating1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reviewers",
                c => new
                    {
                        ReviewerID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ReviewerID);
            
            CreateTable(
                "dbo.ReviewerAlbums",
                c => new
                    {
                        Reviewer_ReviewerID = c.Int(nullable: false),
                        Album_AlbumID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Reviewer_ReviewerID, t.Album_AlbumID })
                .ForeignKey("dbo.Reviewers", t => t.Reviewer_ReviewerID, cascadeDelete: true)
                .ForeignKey("dbo.Albums", t => t.Album_AlbumID, cascadeDelete: true)
                .Index(t => t.Reviewer_ReviewerID)
                .Index(t => t.Album_AlbumID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReviewerAlbums", "Album_AlbumID", "dbo.Albums");
            DropForeignKey("dbo.ReviewerAlbums", "Reviewer_ReviewerID", "dbo.Reviewers");
            DropIndex("dbo.ReviewerAlbums", new[] { "Album_AlbumID" });
            DropIndex("dbo.ReviewerAlbums", new[] { "Reviewer_ReviewerID" });
            DropTable("dbo.ReviewerAlbums");
            DropTable("dbo.Reviewers");
        }
    }
}
