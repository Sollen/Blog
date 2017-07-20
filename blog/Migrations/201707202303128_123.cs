namespace WebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _123 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.ArticleComments", new[] { "ArticleID_ArticleID" });
            DropIndex("dbo.ArticleRatings", new[] { "ArticleID_ArticleID" });
            CreateIndex("dbo.ArticleComments", "ArticleId_ArticleId");
            CreateIndex("dbo.ArticleRatings", "ArticleId_ArticleId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.ArticleRatings", new[] { "ArticleId_ArticleId" });
            DropIndex("dbo.ArticleComments", new[] { "ArticleId_ArticleId" });
            CreateIndex("dbo.ArticleRatings", "ArticleID_ArticleID");
            CreateIndex("dbo.ArticleComments", "ArticleID_ArticleID");
        }
    }
}
