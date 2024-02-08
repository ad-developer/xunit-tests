using Microsoft.EntityFrameworkCore;

namespace Applications.CustormerApp
{
    public interface IApplicationDBContext
	{
        DbSet<Customer> Customers { get; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class, IEntity;

        int SaveChanges();
    }
   
}

