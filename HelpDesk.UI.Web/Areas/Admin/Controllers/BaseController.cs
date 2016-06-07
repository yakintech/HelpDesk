using HelpDesk.Business.BL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelpDesk.Data.Models.ORM.Entity;
using HelpDesk.UI.Web.Areas.Admin.Models.Attributes;

namespace HelpDesk.UI.Web.Areas.Admin.Controllers
{
    [UserLoginControl]
    public class BaseController : Controller
    {
       public GenericRepository<User> rpuser;
        public GenericRepository<Department> rpdepartment;
        public BaseController()
        {

           // ViewBag.UserEMail = HttpContext.User.Identity.Name;

            rpuser = new GenericRepository<User>();
            rpdepartment = new GenericRepository<Department>();
        }

        protected override void Dispose(bool disposing)
        {
            rpuser.Dispose();
            rpdepartment.Dispose();
            base.Dispose(disposing);
        }
    }
}