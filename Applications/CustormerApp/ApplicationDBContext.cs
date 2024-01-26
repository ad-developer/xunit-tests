using Microsoft.EntityFrameworkCore;

namespace Applications.CustormerApp
{
    public class ApplicationDBContext  : DbContext, IApplicationDBContext
    {
		public virtual DbSet<Customer> Customers => Set<Customer>();

		public ApplicationDBContext(DbContextOptions options) : base(options) { }
	}
}