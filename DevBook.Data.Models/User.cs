using System.Collections.Generic;
using DevBook.Data.Models.Abstraction;

namespace DevBook.Data.Models
{
	public class User : DbModel
	{
		public string Login { get; set; }

		public ICollection<Objective> Objectives { get; set; }
	}
}