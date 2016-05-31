using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Data.Models.ORM.Context
{
  public  class HelpDeskContext : DbContext
    {
      public HelpDeskContext()
      {
          //
          Database.Connection.ConnectionString = "";
      }
    }
}
