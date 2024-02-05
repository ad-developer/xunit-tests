using Applications;

namespace UnitTests.SimpleTest
{
    public class TestNoParameters
	{
		public TestNoParameters()
		{
		}

        [Fact]
        [Trait("Category", "Simple test no parameters")]
        public void AddTest()
        {
            // Arrange 
            var sut = new Calculator();

            // Act
            var res = sut.Add(1, 1);

            // Assert 
            Assert.Equal(2, res);
        }
    }
}

