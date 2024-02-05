[assembly: CollectionBehavior(DisableTestParallelization = true)]
namespace UnitTests.Tests.SimpleTest
{
	public class TestParallelSequential
	{
        private readonly int _delay;
        public TestParallelSequential()
		{
            _delay = 4000;
		}

        [Fact]
        [Trait("Category", "Simple test Parallel Sequential")]
        public void SomeTestOne()
        {   // Arrange 
            // Act
            // Assert
            Thread.Sleep(_delay);
            Assert.True(true, "Some Test One");
        }

        [Fact]
        [Trait("Category", "Simple test Parallel Sequential")]
        public void SomeTestTwo()
        {   // Arrange 
            // Act
            // Assert 
            Thread.Sleep(_delay);
            Assert.True(true, "Some Test two");
        }

        [Fact]
        [Trait("Category", "Simple test Parallel Sequential")]
        public void SomeTestThree()
        {   // Arrange 
            // Act
            // Assert
            Thread.Sleep(_delay);
            Assert.True(true, "Some Test Three");
        }
    }
}

