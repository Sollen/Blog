namespace WebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ArticleComments",
                c => new
                    {
                        CommentID = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        ParrentComment = c.Int(nullable: false),
                        Rating = c.Int(nullable: false),
                        ArticleID_ArticleID = c.Int(),
                    })
                .PrimaryKey(t => t.CommentID)
                .ForeignKey("dbo.Articles", t => t.ArticleID_ArticleID)
                .Index(t => t.ArticleID_ArticleID);
            
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        ArticleID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Text = c.String(),
                        Rating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ArticleID);
            
            CreateTable(
                "dbo.ArticleRatings",
                c => new
                    {
                        RatingID = c.Int(nullable: false, identity: true),
                        ValueRating = c.Int(nullable: false),
                        ArticleID_ArticleID = c.Int(),
                    })
                .PrimaryKey(t => t.RatingID)
                .ForeignKey("dbo.Articles", t => t.ArticleID_ArticleID)
                .Index(t => t.ArticleID_ArticleID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ArticleRatings", "ArticleID_ArticleID", "dbo.Articles");
            DropForeignKey("dbo.ArticleComments", "ArticleID_ArticleID", "dbo.Articles");
            DropIndex("dbo.ArticleRatings", new[] { "ArticleID_ArticleID" });
            DropIndex("dbo.ArticleComments", new[] { "ArticleID_ArticleID" });
            DropTable("dbo.ArticleRatings");
            DropTable("dbo.Articles");
            DropTable("dbo.ArticleComments");
        }
    }
}
