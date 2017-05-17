using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Concrete;
using WebUI.Models;


namespace WebUI.Controllers
{
    public class HomeController : Controller
    {

        public EFDBContext context;
        public int countPage = 3;


        public HomeController()
        {
            context = new EFDBContext();
            
            

        }


        public ViewResult Index(int id = 1)
        {          
            ViewBag.page =id;
                        
            return View(ArticleOnPage(checkID(id))); 
        }

        public ViewResult Single(int id)
        {
            var article = context.Articles.Find(id);
            return View(article);
        }

        

        
        private IEnumerable<Article> ArticleOnPage(int page)
        {

            var maxID = context.Articles.Max(Article => Article.ArticleID);
            
            return context.Articles
                .Where<Article>((x) => x.ArticleID >= maxID - page  - countPage + 2 && x.ArticleID <= maxID - (page - 1) * (countPage - 1))
                .OrderByDescending(Article => Article.ArticleID);
        }

        private int checkID(int id)
        {
            int outPage;
            int lastPage;

            if ( id <= 0) {
                outPage = 1;
            }
            else{
                outPage = id;
            }


            if (context.Articles.Count() % countPage == 0) {
                lastPage = context.Articles.Count() / countPage;
            }
            else{
                lastPage = (context.Articles.Count() / countPage) + 1;
            }

            if (outPage > lastPage) {outPage = lastPage; }


            return outPage;
        }


        
    }
}