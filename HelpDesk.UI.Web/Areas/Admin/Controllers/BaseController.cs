using HelpDesk.Business.BL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelpDesk.Data.Models.ORM.Entity;

namespace HelpDesk.UI.Web.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
       public GenericRepository<User> rpuser;
        public BaseController()
        {
            rpuser = new GenericRepository<User>();
        }

        protected override void Dispose(bool disposing)
        {
            rpuser.Dispose();
            base.Dispose(disposing);
        }
    }
}