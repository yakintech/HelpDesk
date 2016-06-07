using HelpDesk.API.Models.DTO;
using HelpDesk.Data.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelpDesk.API.Controllers
{
    public class DepartmentAPIController : BaseAPIController
    {
        [Queryable]
        public IQueryable<DepartmentDTO> GetAllDepartment()
        {
            IQueryable<DepartmentDTO> model =  rpdepartment.GetAll().Select(x => new DepartmentDTO() {
                ID = x.ID,
                Name = x.Name,
                Description = x.Description
            }).AsQueryable();

            return model;
        }
    }
}
