using DevBook.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace DevBook.Data
{
	public class DevBookContext : DbContext
	{
		public static readonly LoggerFactory ConsoleLoggerFactory 
			= new LoggerFactory(new []
			{
				new ConsoleLoggerProvider((c,l) 
					=> c == DbLoggerCategory.Database.Command.Name && l == LogLevel.Information, true)
			});

		public DevBookContext(
			DbContextOptions<DevBookContext> opts) 
			: base(opts) { }

		public DbSet<User> Users { get; set; }

		public DbSet<Contact> Contacts { get; set; }

		public DbSet<Objective> Objectives { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<UserObjective>()
				.HasKey(s => new {s.ObjectiveId, s.UserId});
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseLoggerFactory(ConsoleLoggerFactory);
		}
	}
}