using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Data.Models.ORM.Entity
{
   public class TicketComment : BaseEntity
    {
        public int TicketID { get; set; }
        public int UserID { get; set; }
        public string Comment { get; set; }
    }
}
