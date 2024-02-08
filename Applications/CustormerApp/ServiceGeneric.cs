using Microsoft.EntityFrameworkCore;

namespace Applications.CustormerApp
{
	public class ServiceGeneric<T> where T : class, IEntity
	{
		internal readonly IApplicationDBContext _context;

        public DbSet<T> DbSet => _context.Set<T>();

        public ServiceGeneric(IApplicationDBContext context)
		{
            _context = context;
		}

		public virtual int Add(T entity)
		{
			DbSet.Add(entity);
			_context.SaveChanges();
			return entity.Id;
		}

		public virtual T? GetById(int id)
		{
			var res = DbSet.Where(p => p.Id == id).FirstOrDefault();
			return res;
		}

		public virtual List<T> GetAll()
		{
			var res = DbSet.ToList();
			return res;
		}
	}
}