using HelpDesk.Business.BL.Repository;
using HelpDesk.Data.Models.ORM.Entity;
using HelpDesk.UI.Web.Areas.Admin.Models.Services;
using HelpDesk.UI.Web.Areas.Admin.Models.Types.Enums;
using HelpDesk.UI.Web.Areas.Admin.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;


namespace HelpDesk.UI.Web.Areas.Admin.Controllers
{
    public class AdminLoginController : Controller
    {
        GenericRepository<User> rpuser = new GenericRepository<User>();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginVM model)
        {
            if (ModelState.IsValid)
            {
                if (LoginServices.LoginControl(model))
                {
                    FormsAuthentication.SetAuthCookie(model.EMail, true);
                    return RedirectToAction("Index", "AdminHome");
                }
                else
                {
                    ViewBag.IslemDurum = EnumIslemDurum.GirisBasarisiz;
                    return View();
                }
            }
            else
            {
                ViewBag.IslemDurum = EnumIslemDurum.ValidationHata;
                return View(); 
            }
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "AdminLogin");
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ForgotPassword(LoginVM model)
        {
            return View();
        }



    }
}