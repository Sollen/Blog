using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebUI.Controllers;
using System.Web;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;


namespace WebUI.Tests.Controllers
{
    [TestClass]
    public class HomeContrllerTest
    {
        [TestMethod]
        public void IndexViewResultNotNull()
        {
            HomeController controller = new HomeController();

           
            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
        }
    }
}
