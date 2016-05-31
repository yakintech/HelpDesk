using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Data.Models.ORM.Entity
{
    public class TicketForward : BaseEntity
    {
        public int UserID { get; set; }
        public int NextUserID { get; set; }
        public int TicketID { get; set; }
        public DateTime NextDate { get; set; }

    }
}
