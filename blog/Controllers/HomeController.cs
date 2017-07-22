using System.Linq;
using System.Web.Mvc;
using WebUI.Concrete;
using WebUI.Models;


namespace WebUI.Controllers
{
    public class HomeController : Controller
    {

        public EfdbContext Context;
        public int CountPage = 3;


        public HomeController()
        {
            Context = new EfdbContext();
            
            

        }


        public ViewResult Index(int id = 1)
        {          
            
            ViewBag.CountPage = (Context.Articles.Count() / 3) +1;
            id = CheckId(id);
            ViewBag.page = id;
            return View(ArticleOnPage(id)); 
        }

        public ViewResult Single(int id)
        {
            var article = Context.Articles.Find(id);
            return View(article);
        }

        

        
        private IQueryable<Article> ArticleOnPage(int page)
        {
            return Context.Articles.OrderByDescending(article => article.CreateDate)
                .Skip((page-1)*CountPage)
                .Take(CountPage);
            

        }

       private int CheckId(int id)
        {
            int lastPage;

            var outPage = id <= 0 ? 1 : id;

            if (Context.Articles.Count() % CountPage == 0) {
                lastPage = Context.Articles.Count() / CountPage;
            }
            else{
                lastPage = (Context.Articles.Count() / CountPage) + 1;
            }

            if (outPage > lastPage) {outPage = lastPage; }


            return outPage;
        }

    
        
    }
}