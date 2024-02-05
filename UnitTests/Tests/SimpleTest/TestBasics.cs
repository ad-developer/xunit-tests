namespace UnitTests.SimpleTest
{
    public class TestBasics : IDisposable
	{
		public TestBasics()
		{
           // Initialise test data in the class costrustor     
        }

        [Fact]
        [Trait("Category", "Simple test basics")]
        public void SomeTest()
        {   // Arrange 
            // Act
            // Assert 
            Assert.True(true, "Some Test");
        }

        // Implement IDisposable
        public void Dispose()
        {
            
            // Dispose test data in Dispose of IDisposable
        }
    }
}

