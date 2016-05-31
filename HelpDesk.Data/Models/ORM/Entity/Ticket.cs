using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Data.Models.ORM.Entity
{
   public class Ticket: BaseEntity
    {
        public int UserID { get; set; }
        public int DepartmentID { get; set; }
        public DateTime CreateDate { get; set; }
        public string Content { get; set; }
        public string FilePath { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }

    }
}
