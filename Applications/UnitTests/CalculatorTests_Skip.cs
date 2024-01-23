using Xunit;

namespace Applications.UnitTests
{
    public class CalculatorTests_Skip
	{
		public CalculatorTests_Skip()
		{
		}

        [Fact(Skip = "Need a reason")]
        public void AddTest_Skip()
        {
            var sut = new Calculator();

            var res = sut.Add(1, 1);

            Assert.Equal(2, res);
        }

    }
}

