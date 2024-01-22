using Xunit;
using Xunit.Abstractions;

namespace Applications.UnitTests
{
    public class CalculatorTests
	{
        private readonly int _delay;
        private readonly ITestOutputHelper _output;
        public CalculatorTests(ITestOutputHelper output)
		{
            _delay = 500;
            _output = output;
        }

        [Fact]
        public void AddTest()
        {
            var sut = new Calculator();

            var res = sut.Add(1, 1);

            Thread.Sleep(_delay);

            Assert.Equal(2, res);
            _output.WriteLine($"Calculator was user {sut.HowManyTimesCalculatorUsed()} times.");

        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(15, 5, 10)]
        [InlineData(0, -15, 15)]
        public void AddTest_Theory_InlineData(decimal expected, decimal firstOp, decimal secondOp)
        {
            var sut = new Calculator();

            var res = sut.Add(firstOp, secondOp);

            Thread.Sleep(_delay);

            Assert.Equal(expected, res);
            _output.WriteLine($"Calculator was user {sut.HowManyTimesCalculatorUsed()} times.");
        }

        [Theory]
        [MemberData(nameof(GetData), parameters: 3)]
        public void AddTest_Theory_MemberData(decimal expected, decimal firstOp, decimal secondOp)
        {
            var sut = new Calculator();

            var res = sut.Add(firstOp, secondOp);

            Thread.Sleep(_delay);

            Assert.Equal(expected, res);
            _output.WriteLine($"Calculator was user {sut.HowManyTimesCalculatorUsed()} times.");
        }



        [Theory]
        [ClassData(typeof(CalculatorTestData))]
        public void AddTest_Theory_ClassData(decimal expected, decimal firstOp, decimal secondOp)
        {
            var sut = new Calculator();

            var res = sut.Add(firstOp, secondOp);

            Thread.Sleep(_delay);

            Assert.Equal(expected, res);
            _output.WriteLine($"Calculator was user {sut.HowManyTimesCalculatorUsed()} times.");
        }


        [Fact(Skip = "Need a reason")]
        public void AddTest_Skip()
        {
            var sut = new Calculator();

            var res = sut.Add(1, 1);

            Assert.Equal(2, res);
        }

        public static IEnumerable<object[]> GetData(int numTests)
        {
            var allData = new List<object[]>
        {
            new object[] { 3, 2, 1 },
            new object[] {-10,  -4, -6 },
            new object[] { 0, -2, 2 }
        };

            return allData.Take(numTests);
        }

    }
}

