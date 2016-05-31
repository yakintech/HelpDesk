using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Data.Models.ORM.Entity
{
   public class TicketHistory : BaseEntity
    {
        public int TicketID { get; set; }
        public int UserID { get; set; }
        public string Status { get; set; }
        public DateTime LastUpdated { get; set; }
        public string Content { get; set; }

    }
}
