using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Data.Models.ORM.Entity
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
