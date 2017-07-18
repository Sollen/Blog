namespace WebUI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebUI.Concrete.EFDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WebUI.Concrete.EFDBContext";
        }

        protected override void Seed(WebUI.Concrete.EFDBContext context)
        {
           
        }
    }
}
