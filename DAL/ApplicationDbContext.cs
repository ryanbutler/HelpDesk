using HelpDesk.Models;
using HelpDesk.ViewModel;
using Microsoft.EntityFrameworkCore;
namespace HelpDesk.DAL
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Severities> Severity { get; set; }
        public DbSet<Departments> Department { get; set; }
        public DbSet<Personnels> Personnel {get; set; }
        public DbSet<TicketViewModel> TicketViewModel { get; set; }
        public DbSet<Tickets> Ticket { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TicketViewModel>().HasNoKey();
        }
	    
    }
}
