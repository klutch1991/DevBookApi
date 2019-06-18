using System;

namespace DevBook.Data.Models.Abstraction
{
	public interface IDbModel
	{
		Guid Id { get; set; }
	}
}