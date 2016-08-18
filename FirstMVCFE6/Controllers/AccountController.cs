using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVCFE6.Models;

namespace FirstMVCFE6.Controllers
{
    public class AccountController : Controller
    {
        private DAL.AccountContext db = new DAL.AccountContext();
        //
        // GET: /Account/
        public ActionResult Index()
        {
            return View(db.SysUsers);
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
        public ActionResult Details(int Id)
        {
            SysUser sysUser = db.SysUsers.Find(Id);

            return View(sysUser);
        }


        //增加用户
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(SysUser sysUser)
        {
            db.SysUsers.Add(sysUser);

            db.SaveChanges();

            return RedirectToAction("Index");
        
        }


        //修改用户
        public ActionResult Edit(int Id)
        {
            SysUser sysUser = db.SysUsers.Find(Id);
            return View(sysUser);
        }



        [HttpPost]
        public ActionResult Edit(SysUser sysUser)
        {
            db.Entry(sysUser).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index"); 
        }


        //删除用户
        public ActionResult Delete(int Id)
        {
            SysUser sysUser = db.SysUsers.Find(Id);

            return View(sysUser);
        }



        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int Id)
        {
            SysUser sysUser = db.SysUsers.Find(Id);

            db.SysUsers.Remove(sysUser);

            db.SaveChanges();

            return RedirectToAction("Index");
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