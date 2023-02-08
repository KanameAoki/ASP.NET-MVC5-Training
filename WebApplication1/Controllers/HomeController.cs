using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(new UserModel());
        }

        /// <summary>
        /// ID/パスワードをpostされたときの処理
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Index(UserModel user)
        {
            return RedirectToAction("Hello", user);
        }

        /// <summary>
        ///　マイページ、NotFoundページの表示
        /// abc以外のID/パスワードを入力した場合、NotFoundページに遷移する
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public ActionResult Hello(UserModel user)
        {
            if (string.IsNullOrEmpty(user.UserID) && string.IsNullOrEmpty(user.Password))
            {
                return RedirectToAction("Index");
            }
            if (user.UserID != "abc" || user.Password != "abc") 
            {
                return RedirectToAction("NotFound");
            }
            return View(user);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult NotFound(UserModel user)
        {
            return View();
        }   
    }        
}