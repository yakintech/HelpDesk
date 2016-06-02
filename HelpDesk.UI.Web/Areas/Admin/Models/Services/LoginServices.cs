using HelpDesk.UI.Web.Areas.Admin.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HelpDesk.Business.BL.Repository;
using HelpDesk.Data.Models.ORM.Entity;

namespace HelpDesk.UI.Web.Areas.Admin.Models.Services
{
    public class LoginServices
    {
        public static bool LoginControl(LoginVM model)
        {
            GenericRepository<User> rpuser = new GenericRepository<User>();
            bool logincontrol = rpuser.Any(x => x.EMail == model.EMail && x.Password == model.Password);

            return logincontrol;


        }
    }
}