using System;
using DevBook.Data.Models.Abstraction;

namespace DevBook.Data.Models
{
	public class UserObjective : DbModel
	{
		public Guid UserId { get; set; }

		public User User { get; set; }

		public Guid ObjectiveId { get; set; }

		public Objective Objective { get; set; }
	}
}