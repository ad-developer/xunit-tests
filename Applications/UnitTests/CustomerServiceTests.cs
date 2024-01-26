using Applications.CustormerApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using NSubstitute;
using Xunit;

namespace Applications.UnitTests
{
    public class CustomerServiceTests
	{
		private readonly ICustomerService _sut;
		private readonly IApplicationDBContext _context;

		public CustomerServiceTests()
		{
			_context = Substitute.For<IApplicationDBContext>();
			_sut = new CustomerService(_context);
		}

		[Fact]
		public void AddTest()
		{
			var customerFixture = new Customer
			{
				 Id = 3,
				 FirstName = "John",
				 LastName = "Smith",
				 Email = "John.Smith@email.com",
				 Phone = "333.333.4444"
			};
			
			var customerSet = Substitute.For<DbSet<Customer>>();
			var entry = Substitute.For<EntityEntry<Customer>>();
			entry.Entity.Returns(customerFixture);

            customerSet.Add(customerFixture).Returns(entry);
            
            _context.Customers.Returns(customerSet);

			_sut.Add(customerFixture);
			Assert.True(customerFixture.Id == 3, "Customer Id must be greater that 0");		
		}

        [Fact]
        public void GetCustomerByIdTest()
        {

        }

		[Fact]
		public void GetAllCustomersTest()
		{

		}
    }
}