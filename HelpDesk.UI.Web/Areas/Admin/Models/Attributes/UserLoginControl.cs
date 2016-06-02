using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelpDesk.UI.Web.Areas.Admin.Models.Attributes
{
    public class UserLoginControl : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!HttpContext.Current.User.Identity.IsAuthenticated)
            {
                filterContext.HttpContext.Response.Redirect("/Admin/AdminLogin/Index");
            }
        }
    }
}