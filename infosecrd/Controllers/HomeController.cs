using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using infosecrd.Models;

namespace infosecrd.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            dbManage db = new dbManage();
            return View(db.SelectRecentArticles());
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Signup()
        {
            return View();
        }
        public ActionResult Noticia(int? Id)
        {
            dbManage db = new dbManage();
            return View(db.SelectArticlebyid(Id));
        }



    }
}