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
        

        public HomeController()
        {
            context = new EFDBContext();
            

        }
        

        public ActionResult Index(int? id)
        {
            if (id == null) { id = 0; }
            int countPage = 3;
            
           var article = context.Articles.Where<Article>((x) => x.ArticleID >= (id-1)*countPage && x.ArticleID < ((id - 1) * countPage) + countPage);
            return View(article);
        }


    }
}