using System.Collections.Generic;
using DevBook.Data.Models.Abstraction;

namespace DevBook.Data.Models
{
	public class User : DbModel
	{
		public List<UserObjective> UserObjectives { get; set; }

		public ICollection<Contact> Contacts { get; set; }

		public string Login { get; set; }
	}
}