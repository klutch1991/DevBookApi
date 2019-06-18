using DevBook.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DevBook.Data
{
	public class DevBookContext : DbContext
	{
		public DevBookContext(
			DbContextOptions<DevBookContext> options)
			: base(options)
		{
		}

		public DbSet<User> Users { get; set; }

		public DbSet<Objective> Objectives { get; set; }

		//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		//{
		//	optionsBuilder
		//		.UseSqlServer(
		//			"Server = (localdb)\\mssqllocaldb; Database = DevBookDb; Integrated security = false;");
		//}
	}
}