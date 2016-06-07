using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HelpDesk.Business.BL.Repository;
using HelpDesk.Data.Models.ORM.Entity;

namespace HelpDesk.API.Controllers
{
    public class BaseAPIController : ApiController
    {
       public GenericRepository<Department> rpdepartment;
        public BaseAPIController()
        {
           
            rpdepartment = new GenericRepository<Department>();
        }

        protected override void Dispose(bool disposing)
        {
            rpdepartment.Dispose();
            base.Dispose(disposing);    
        }
    }
}
