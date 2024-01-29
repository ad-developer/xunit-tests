using Xunit;

namespace Applications.UnitTests
{
    public class CalculatorTests_NoParam
	{
		public CalculatorTests_NoParam()
		{
		}

        [Fact]
        [Trait("Application", "Calculator")]
        public void AddTest()
        {
            var sut = new Calculator();

            var res = sut.Add(1, 1);
            Assert.Equal(2, res);
        }
    }
}

