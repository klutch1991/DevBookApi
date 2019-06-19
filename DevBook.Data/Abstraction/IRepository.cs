using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DevBook.Data.Models.Abstraction;

namespace DevBook.Data.Abstraction
{
	public interface IRepository<TDbModel> where TDbModel : IDbModel
	{
		Task<TDbModel> GetAsync(Guid id);

		Task<IReadOnlyList<TDbModel>> GetAsync(Expression<Func<TDbModel, bool>> predicateExpression);

		void Add(TDbModel model);

		Task<bool> CommitAsync();
	}
}