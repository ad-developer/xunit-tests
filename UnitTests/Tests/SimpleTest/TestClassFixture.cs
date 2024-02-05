using Applications;

namespace UnitTests.Tests.SimpleTest
{
    public class TestClassFixture : IClassFixture<Calculator>
    {
        private Calculator _sut;
      
        public TestClassFixture(Calculator sut)
		{
            _sut = sut;
		}

        [Fact]
        [Trait("Category", "Simple Test class fixture")]
        public void AddTest()
        {
            // Arrange 

            // Act
            var res = _sut.Add(1, 1);

            // Assert 
            Assert.Equal(2, res);
        }
    }
}

