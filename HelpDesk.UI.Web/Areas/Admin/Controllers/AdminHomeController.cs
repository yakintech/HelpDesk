using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelpDesk.UI.Web.Areas.Admin.Controllers
{
    public class AdminHomeController : BaseController
    {
        public ActionResult Index()
        {
          var test =  rpuser.GetAll();
            return View();
        }
    }
}