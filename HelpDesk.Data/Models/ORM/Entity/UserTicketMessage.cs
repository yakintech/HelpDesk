using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Data.Models.ORM.Entity
{
    public class UserTicketMessage : BaseEntity
    {
        public int SenderUserID { get; set; }
        public int TicketID { get; set; }
        public int ReceiverUserID { get; set; }
    }
}
