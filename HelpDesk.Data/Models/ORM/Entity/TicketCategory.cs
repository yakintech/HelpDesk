using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Data.Models.ORM.Entity
{
    public class TicketCategory : BaseEntity
    {
        public int DepartmentID { get; set; }

        public string Name { get; set; }
    }
}
