using HelpDesk.Data.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Data.Models.ORM.Context
{
  public  class HelpDeskContext : DbContext
    {
      public HelpDeskContext()
      {
          Database.Connection.ConnectionString = "";
      }

      protected override void OnModelCreating(DbModelBuilder modelBuilder)
      {
          modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
      }

      public DbSet<User> Users { get; set; }
      public DbSet<Department> Departments{ get; set; }
      public DbSet<TicketCategory> TicketCategories { get; set; }
      public DbSet<Ticket> Tickets { get; set; }
      public DbSet<TicketHistory> TicketHistories { get; set; }
      public DbSet<UserTicket> UserTickets { get; set; }
      public DbSet<TicketComment> TicketComments { get; set; }
      public DbSet<TicketForward> TicketForwards { get; set; }
      public DbSet<UserTicketMessage> UserTicketMessages { get; set; }




    }
}
