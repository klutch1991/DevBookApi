
using System.Collections.Generic;
using DevBook.Data.Models.Abstraction;

namespace DevBook.Data.Models
{
	public class Objective : DbModel
	{
		public List<UserObjective> UserObjectives { get; set; }

		public string Description { get; set; }
	}
}