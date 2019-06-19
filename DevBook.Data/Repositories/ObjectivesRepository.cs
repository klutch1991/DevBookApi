using DevBook.Data.Abstraction;
using DevBook.Data.Models;

namespace DevBook.Data.Repositories
{
	public class ObjectivesRepository : Repository<Objective>
	{
		public ObjectivesRepository(DevBookContext context) : base(context)
		{
		}
	}
}