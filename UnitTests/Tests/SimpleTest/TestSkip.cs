namespace UnitTests.Tests.SimpleTest
{
	public class TestSkip
	{
		public TestSkip()
		{
		}

        [Fact(Skip = "Add here a reason for skip")]
        [Trait("Category", "Simple test skip")]
        public void SomeTest()
        {   // Arrange 
            // Act
            // Assert 
            Assert.True(true, "Some Test");
        }
    }
}