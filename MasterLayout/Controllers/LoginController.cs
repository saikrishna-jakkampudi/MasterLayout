using MasterLayout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MasterLayout.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult LoginPage()
        {
            return View();
        }
        public ActionResult HomePage(tbl_Login L)
        {
            if (ModelState.IsValid)
            {
                string Username = Request.Form["username"];
                string Password = Request.Form["password"];
                string msg = LoginOperations.login(Username, Password);
                ViewBag.Welcome = msg;
                if (msg != null)
                {
                    return View();
                }
                else
                {
                    ViewBag.Error = "Invalid Credentials";
                    return View("LoginPage");
                }
            }
            else
            {
                return View("LoginPage");
            }
        }
    }
}