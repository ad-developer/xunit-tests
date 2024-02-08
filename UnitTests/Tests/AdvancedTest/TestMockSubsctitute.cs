using Applications.CustormerApp;
using UnitTests.Fixtures;

namespace UnitTests.Tests.AdvancedTest
{
    public class TestMockSubsctitute
	{
        public TestMockSubsctitute()
		{
           
        }

        [Fact]
        [Trait("Category", "Mock Substitute")]
        public void AddCutomerOneTest()
        {
            // Arrange 
            var context = ApplicationDbContextFixture.Create();
            var sut = new CustomerServiceOne(context);

            var customerFixture = new Customer
            {
                Id = 0,
                FirstName = "John",
                LastName = "Smith",
                Email = "John.Smith@email.com",
                Phone = "333.333.4444"
            };

            // Act
            sut.Add(customerFixture);
            var customer = context.Customers.First();

            // Assert
            Assert.True(customer.Id > 0, $"Customer Id is {customer.Id} and it's more than 0");
            Assert.True(customer.FirstName == "John", "Customer first name is John");
        }

        [Theory]
        [InlineData(3, "John")]
        [InlineData(5, "Michael")]
        [Trait("Category", "Mock Substitute")]
        public void GetCustomerByIdOneTest(int id, string name)
        {
            // Arrange 
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

            var sut = new CustomerServiceOne(context);

            // Act
            var customer = sut.GetCustomerById(id);

            // Assert
            Assert.True(customer.FirstName == name, $"Customer first name is {name}");
        }

        [Fact]
        [Trait("Category", "Mock Substitute")]
        public void GetAllCustomersOneTest()
        {
            // Arrange 
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

            var sut = new CustomerServiceOne(context);

            // Act
            var customer = sut.GetAllCustomers();

            // Assert
            Assert.True(customer.Count == 2, "Total number of customers is 2");
        }

        [Fact]
        [Trait("Category", "Mock Substitute")]
        public void AddCutomerTwoTest()
        {
            // Arrange 
            var context = GenericApplicationDbContextFixture<Customer>.Create();
            var sut = new CustomerServiceTwo(context);

            var customerFixture = new Customer
            {
                Id = 0,
                FirstName = "John",
                LastName = "Smith",
                Email = "John.Smith@email.com",
                Phone = "333.333.4444"
            };

            // Act
            sut.Add(customerFixture);
            var customer = context.Set<Customer>().FirstOrDefault();

            // Assert
            Assert.NotNull(customer);
            Assert.True(customer.Id > 0, $"Customer Id is {customer.Id} and it's more than 0");
            Assert.True(customer.FirstName == "John", "Customer first name is John");
        }

        [Theory]
        [InlineData(3, "John")]
        [InlineData(5, "Michael")]
        [Trait("Category", "Mock Substitute")]
        public void GetCustomerByIdTwoTest(int id, string name)
        {
            // Arrange 
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

            var context = GenericApplicationDbContextFixture<Customer>.Create(customers);

            var sut = new CustomerServiceTwo(context);

            // Act
            var customer = sut.GetById(id);

            // Assert
            Assert.NotNull(customer);
            Assert.True(customer.FirstName == name, $"Customer first name is {name}");
        }

        [Fact]
        [Trait("Category", "Mock Substitute")]
        public void GetAllCustomersTwoTest()
        {
            // Arrange 
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

            var context = GenericApplicationDbContextFixture<Customer>.Create(customers);

            var sut = new CustomerServiceTwo(context);

            // Act
            var customer = sut.GetAll();

            // Assert
            Assert.True(customer.Count == 2, "Total number of customers is 2");
        }
    }
}

