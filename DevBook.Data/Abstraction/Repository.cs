using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DevBook.Data.Models.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DevBook.Data.Abstraction
{
	public abstract class Repository<TDbModel> : IRepository<TDbModel> where TDbModel : DbModel
	{
		private readonly DevBookContext _context;

		protected Repository(
			DevBookContext context) 
				=> _context = context;

		public virtual Task<TDbModel> GetAsync(Guid id)
			=> _context.Set<TDbModel>().FindAsync(id);

		public virtual async Task<IReadOnlyList<TDbModel>> GetAsync(
			Expression<Func<TDbModel, bool>> predicateExpression)
				=> await _context.Set<TDbModel>().Where(predicateExpression).ToListAsync();

		public virtual void Add(TDbModel model)
			=> _context.Add(model);

		public virtual async Task<bool> CommitAsync()
			=> await _context.SaveChangesAsync() > 0;
	}
}