
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogic;
using BusinessObject;

namespace WebAppUser.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(UserBO objUserBO)
        {
            if (ModelState.IsValid)
            {
                UserBL objUserBL = new UserBL();
                CustomBO objCustomBO = objUserBL.AddUser(objUserBO);
                return RedirectToAction("Index");
            }
            return View(objUserBO);
        }
    }

}