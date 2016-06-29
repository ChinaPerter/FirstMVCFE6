using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCFE6.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            ViewBag.LoginState = "登录前。。。。。";
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection fc   )
        {
            string strEmail = fc["InputEmail"];
            string password = fc["InputPassword"];

            ViewBag.LoginState = strEmail +   "登录后。。。。。";

            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        //public ActionResult Action()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Action()
        //{
        //    return View();
        //}

	}
}