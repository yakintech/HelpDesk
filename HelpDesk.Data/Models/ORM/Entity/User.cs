using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Data.Models.ORM.Entity
{
    public class User : BaseEntity
    {
        public string Name { get; set; }

        public string EMail { get; set; }

        public string Password { get; set; }

        public bool IsActive { get; set; }

        public int DepartmentID { get; set; }

    }
}
