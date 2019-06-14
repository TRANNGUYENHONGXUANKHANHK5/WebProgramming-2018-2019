using Final_Project_B.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final_Project_B.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Autherize(Final_Project_B.Models.Login_Info loginModel)
        {
            using(Project_B_FinalEntities5 db = new Project_B_FinalEntities5())
            {
                var userDetails = db.Login_Info.Where(x => x.UserName == loginModel.UserName && x.Password == loginModel.Password).FirstOrDefault();
                if(userDetails == null)
                {
                    loginModel.LoginErrorMessage = "Sai tài khoản hoặc mật khẩu";
                    return View("Index", loginModel);
                }
                else
                {
                    Session["userID"] = userDetails.UserID;
                    return RedirectToAction("Default", "Home");
                }
            }
        }

        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}