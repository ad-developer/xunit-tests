namespace UnitTests.Tests.SimpleTest
{
	public class TestMultipleTraits
	{
		public TestMultipleTraits()
		{
		}

        [Fact]
        [Trait("Category", "Trait multiple traits: one")]
        [Trait("Category", "Trait multiple traits: two")]
        [Trait("Category", "Trait multiple traits: three")]
        public void SomeTest()
        {   // Arrange 
            // Act
            // Assert 
            Assert.True(true, "Some Test");
        }
    }
}

