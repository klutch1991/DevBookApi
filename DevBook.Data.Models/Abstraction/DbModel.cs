using System;

namespace DevBook.Data.Models.Abstraction
{
	public abstract class DbModel : IDbModel
	{
		public Guid Id { get; set; }
	}
}