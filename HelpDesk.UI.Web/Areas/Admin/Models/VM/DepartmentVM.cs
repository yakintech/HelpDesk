using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HelpDesk.UI.Web.Areas.Admin.Models.VM
{
    public class DepartmentVM : BaseVM
    {
        [Required]
        [Display(Name="Ad")]
        public string Name { get; set; }

        [Display(Name="Açıklama")]
        public string Description { get; set; }
    }
}