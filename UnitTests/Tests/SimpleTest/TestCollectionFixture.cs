using Applications;
using Xunit.Abstractions;

namespace UnitTests.Tests.SimpleTest
{

    [CollectionDefinition(name: "Guid Generator")]
    public class GuidGeneratorDefinition : ICollectionFixture<GuidGenerator> { }

    [Collection(name: "Guid Generator")]
    public class TestCollectionFixtureOne
	{
        private readonly GuidGenerator _sut;
        private readonly ITestOutputHelper _output;

        public TestCollectionFixtureOne(ITestOutputHelper output, GuidGenerator sut)
		{
            _sut = sut;
            _output = output;
		}

        [Fact]
        [Trait("Category", "Simple test ollection fixture")]
        void GuidTest()
        {
            // Arrange 

            // Act
            var guid = _sut.RandomGuid;

            //Assert
            _output.WriteLine($"The guid is {guid}");
        }
    }

    [Collection(name: "Guid Generator")]
    public class TestCollectionFixtureTwo
    {
        private readonly GuidGenerator _sut;
        private readonly ITestOutputHelper _output;

        public TestCollectionFixtureTwo(ITestOutputHelper output, GuidGenerator sut)
        {
            _sut = sut;
            _output = output;
        }

        [Fact]
        [Trait("Category", "Simple test ollection fixture")]
        void GuidTest()
        {
            // Arrange 

            // Act
            var guid = _sut.RandomGuid;

            //Assert
            _output.WriteLine($"The guid is {guid}");
        }
    }

    [Collection(name: "Guid Generator")]
    public class TestCollectionFixtureThree
    {
        private readonly GuidGenerator _sut;
        private readonly ITestOutputHelper _output;

        public TestCollectionFixtureThree(ITestOutputHelper output, GuidGenerator sut)
        {
            _sut = sut;
            _output = output;
        }

        [Fact]
        [Trait("Category", "Simple test ollection fixture")]
        void GuidTest()
        {
            // Arrange 

            // Act
            var guid = _sut.RandomGuid;

            //Assert
            _output.WriteLine($"The guid is {guid}");
        }
    }
}

