using Xunit;

[assembly: CollectionBehavior(DisableTestParallelization = true)]

namespace Applications.UnitTests
{
	public class CalculatorTests_Sequential
	{
        private readonly int _delay; 
		public CalculatorTests_Sequential()
		{
            _delay = 0;
		}

        [Fact]
        public void AddTest()
        {
            var sut = new Calculator();

            var res = sut.Add(1, 1);

            Thread.Sleep(_delay);

            Assert.Equal(2, res);
        }

        [Theory]
        [ClassData(typeof(CalculatorTestData))]
        public void AddTest_Theory_ClassData(decimal expected, decimal firstOp, decimal secondOp)
        {
            var sut = new Calculator();

            var res = sut.Add(firstOp, secondOp);

            Thread.Sleep(_delay);

            Assert.Equal(expected, res);
        }
    }
}

