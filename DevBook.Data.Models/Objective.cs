using System;
using DevBook.Data.Models.Abstraction;

namespace DevBook.Data.Models
{
	public class Objective : DbModel
	{
		public Guid UserId { get; set; }
		public User User { get; set; }

		public string Description { get; set; }
	}
}