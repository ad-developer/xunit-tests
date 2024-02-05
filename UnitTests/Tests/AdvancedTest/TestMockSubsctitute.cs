using Applications.CustormerApp;
using Microsoft.EntityFrameworkCore;
using NSubstitute;

namespace UnitTests.Tests.AdvancedTest
{
    public class TestMockSubsctitute
	{
        private readonly ICustomerService _sut;
        private readonly IApplicationDBContext _context;

        public TestMockSubsctitute()
		{
            _context = Substitute.For<IApplicationDBContext>();
            _sut = new CustomerService(_context);
        }

        [Fact(Skip = "Not implemented")]
        [Trait("Application", "Customer Service")]
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

            var customerSet = Substitute.For<DbSet<Customer>, IQueryable<Customer>>();

            var customers = new List<Customer>();
            var data = customers.AsQueryable();

            customerSet.Add(Arg.Do<Customer>(foo =>
            {
                customers.Add(customerFixture);
                // at this point you have to recreate the added IQueryable
                data = customers.AsQueryable();
                // rest of code you had to add this to the mockDbSet
            }));

            //var entry = Substitute.For<EntityEntry<Customer>>();
            //entry.Entity.Returns(customerFixture);

            //customerSet.Add(customerFixture).Returns(entry);

            _context.Customers.Returns(customerSet);

            _sut.Add(customerFixture);
            Assert.True(customerFixture.Id == 3, "Customer Id must be greater that 0");
        }

        [Fact]
        [Trait("Application", "Customer Service")]
        public void GetCustomerByIdTest()
        {

        }

        [Fact]
        [Trait("Application", "Customer Service")]
        public void GetAllCustomersTest()
        {

        }
    }
}

