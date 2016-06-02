using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HelpDesk.UI.Web.Areas.Admin.Models.VM
{
    public class LoginVM
    {
        [EmailAddress]
        [Required]
        public string EMail { get; set; }

        [Required]
        public string Password { get; set; }
    }
}