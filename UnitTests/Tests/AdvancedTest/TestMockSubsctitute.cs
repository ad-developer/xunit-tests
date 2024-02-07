using System.Xml.Linq;
using Applications.CustormerApp;
using Castle.Core.Resource;
using UnitTests.Fixtures;

namespace UnitTests.Tests.AdvancedTest
{
    public class TestMockSubsctitute
	{
        public TestMockSubsctitute()
		{
           
        }

        [Fact]
        [Trait("Application", "Customer Service")]
        public void AddTest()
        {
            var customers = new List<Customer>();
            var context = ApplicationDbContextFixture.Create(customers);

            var sut = new CustomerService(context);

            var customerFixture = new Customer
            {
                Id = 0,
                FirstName = "John",
                LastName = "Smith",
                Email = "John.Smith@email.com",
                Phone = "333.333.4444"
            };

            sut.Add(customerFixture);
            var customer = context.Customers.First();
           
            Assert.True(customer.Id > 0, $"Customer Id is {customer.Id} and it's more than 0");
            Assert.True(customer.FirstName == "John", "Customer first name is John");
        }

        [Theory]
        [InlineData(3, "John")]
        [InlineData(5, "Michael")]
        [Trait("Application", "Customer Service")]
        public void GetCustomerByIdTest(int id, string name)
        {
            var customers = new List<Customer>();
            var customerFixtureOne = new Customer
            {
                Id = 3,
                FirstName = "John",
                LastName = "Smith",
                Email = "John.Smith@email.com",
                Phone = "333.333.4444"
            };

            var customerFixtureTwo = new Customer
            {
                Id = 5,
                FirstName = "Michael",
                LastName = "Jones",
                Email = "Michael.Jones@email.com",
                Phone = "333.333.5555"
            };
            customers.Add(customerFixtureOne);
            customers.Add(customerFixtureTwo);

            var context = ApplicationDbContextFixture.Create(customers);

            var sut = new CustomerService(context);

            var customer = sut.GetCustomerById(id);
            Assert.True(customer.FirstName == name, $"Customer first name is {name}");
        }

        [Fact]
        [Trait("Application", "Customer Service")]
        public void GetAllCustomersTest()
        {
            var customers = new List<Customer>();
            var customerFixtureOne = new Customer
            {
                Id = 3,
                FirstName = "John",
                LastName = "Smith",
                Email = "John.Smith@email.com",
                Phone = "333.333.4444"
            };

            var customerFixtureTwo = new Customer
            {
                Id = 5,
                FirstName = "Michael",
                LastName = "Jones",
                Email = "Michael.Jones@email.com",
                Phone = "333.333.5555"
            };
            customers.Add(customerFixtureOne);
            customers.Add(customerFixtureTwo);

            var context = ApplicationDbContextFixture.Create(customers);

            var sut = new CustomerService(context);

            var customer = sut.GetAllCustomers();
            Assert.True(customer.Count == 2, "Total number of customers is 2");
        }
    }
}

