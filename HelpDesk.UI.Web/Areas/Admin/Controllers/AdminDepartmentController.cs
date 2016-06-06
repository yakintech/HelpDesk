using HelpDesk.Data.Models.ORM.Entity;
using HelpDesk.UI.Web.Areas.Admin.Models.Types.Enums;
using HelpDesk.UI.Web.Areas.Admin.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelpDesk.UI.Web.Areas.Admin.Controllers
{
    public class AdminDepartmentController : BaseController
    {
        public ActionResult Index()
        {
            List<DepartmentVM> model = rpdepartment.GetAll().Select(x => new DepartmentVM()
            {
                Name = x.Name,
                Description = x.Description,
                ID = x.ID
            }).ToList();

            return View();
        }

        public ActionResult AddDepartment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddDepartment(DepartmentVM model)
        {
            if (ModelState.IsValid)
            {
                Department department = new Department();
                department.Name = model.Name;
                department.Description = model.Description;

                rpdepartment.Add(department);
                ViewBag.IslemDurum = EnumIslemDurum.IslemBasarili;
                ModelState.Clear();
                return View();
            }
            else
            {
                ViewBag.IslemDurum = EnumIslemDurum.ValidationHata;
                return View();
            }
        }

        public ActionResult DeleteDepartment(int id)
        {
           bool result = rpdepartment.Delete(id);
            if (result)
            {
                return RedirectToAction("Index", "AdminDepartment");
            }
            else
            {
                return RedirectToAction("Index", "AdminDepartment");
            }

        }

        public ActionResult UpdateDepartment(int id)
        {
            Department department = rpdepartment.FirstOrDefault(x => x.ID == id);

            DepartmentVM model = new DepartmentVM();
            model.Name = department.Name;
            model.Description = department.Description;

            return View(model);
        }

        [HttpPost]
        public ActionResult UpdateDepartment(DepartmentVM model)
        {
            if (ModelState.IsValid)
            {
                Department department = rpdepartment.FirstOrDefault(x => x.ID == model.ID);
                department.Name = model.Name;
                department.Description = model.Description;
                rpdepartment.SaveChanges();
                ViewBag.IslemDurum = EnumIslemDurum.IslemBasarili;
                return View();

            }
            else
            {
                ViewBag.IslemDurum = EnumIslemDurum.ValidationHata;
                return View();
            }
        }

    }
}