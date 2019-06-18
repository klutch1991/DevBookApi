using System;
using DevBook.Data.Models.Abstraction;

namespace DevBook.Data.Models
{
	public class Contact : DbModel
	{
		public Guid UserId { get; set; }

		public User User { get; set; }

		public ContactType ContactType { get; set; }

		public string Value { get; set; }
	}
}