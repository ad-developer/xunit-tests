using Applications.CustormerApp;
using Microsoft.EntityFrameworkCore;
using NSubstitute;
using UnitTests.Fixtures;

namespace UnitTests.Tests.AdvancedTest
{
    public class TestMockSubsctitute
	{
        private readonly ICustomerService _sut;
        private readonly IApplicationDBContext _context;

        public TestMockSubsctitute()
		{
            var customers = new List<Customer>(); 
            _context = ApplicationDbContextFixture.Create(customers);

            _sut = new CustomerService(_context);
        }

        [Fact]
        [Trait("Application", "Customer Service")]
        public void AddTest()
        {

            var customerFixture = new Customer
            {
                Id = 0,
                FirstName = "John",
                LastName = "Smith",
                Email = "John.Smith@email.com",
                Phone = "333.333.4444"
            };

            _sut.Add(customerFixture);
            var customer = _context.Customers.First();
           
            Assert.True(customer.Id > 0, $"Customer Id is {customer.Id} and it's more than 0");
            Assert.True(customer.FirstName == "John", "Customer first name is John");
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

