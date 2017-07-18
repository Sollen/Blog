namespace WebUI.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddCreateDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ArticleComments", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Articles", "CreateDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Articles", "CreateDate");
            DropColumn("dbo.ArticleComments", "CreateDate");
        }
    }
}
