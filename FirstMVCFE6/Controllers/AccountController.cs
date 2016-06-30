using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCFE6.Controllers
{
    public class AccountController : Controller
    {
        private DAL.AccountContext db = new DAL.AccountContext();
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

            var user = db.SysUsers.Where(b => b.Email == strEmail & b.Password == password);
            if (user.Count() > 0)
            {
                ViewBag.LoginState = strEmail + "登录成功。。。。。";
            }
            else
            {
                ViewBag.LoginState = strEmail + "用户不存在。。。。。";

            }

            

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