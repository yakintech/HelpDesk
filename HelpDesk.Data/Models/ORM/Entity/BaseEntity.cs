using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Data.Models.ORM.Entity
{
   public class BaseEntity
    {
        public int ID { get; set; }

        public DateTime AddDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletedDate { get; set; }

        public bool IsDeleted { get; set; }
    }
}
