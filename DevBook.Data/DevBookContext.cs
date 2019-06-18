using DevBook.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DevBook.Data
{
	public class DevBookContext : DbContext
	{
		public DevBookContext(
			DbContextOptions<DevBookContext> opts) 
			: base(opts) { }

		public DbSet<User> Users { get; set; }

		public DbSet<Objective> Objectives { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<UserObjective>()
				.HasKey(s => new {s.ObjectiveId, s.UserId});
		}
	}
}