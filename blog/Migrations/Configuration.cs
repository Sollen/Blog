namespace WebUI.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<WebUI.Concrete.EfdbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WebUI.Concrete.EFDBContext";
        }

        protected override void Seed(WebUI.Concrete.EfdbContext context)
        {
           
        }
    }
}
