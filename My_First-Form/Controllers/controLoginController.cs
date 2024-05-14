using My_First_Form.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace My_First_Form.Controllers
{
    public class controLoginController : Controller
    {
        // GET: controLogin
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Action01(model01 m1)
        {
            return View("Action01",m1);
        }
        [HttpPost]
        public ViewResult Action02(model02 m2)
        {
            return View("Action02",m2);

        }
    }

    
   
}