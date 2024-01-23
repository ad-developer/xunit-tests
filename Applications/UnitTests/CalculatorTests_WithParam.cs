using Xunit;
using Xunit.Abstractions;

namespace Applications.UnitTests
{
    public class CalculatorTests_WithParam
	{
        private readonly int _delay;
        private readonly ITestOutputHelper _output;
        public CalculatorTests_WithParam(ITestOutputHelper output)
		{
            _delay = 0;
            _output = output;
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

        /// <summary>
        /// Member data with param
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="firstOp"></param>
        /// <param name="secondOp"></param>
        [Theory]
        [MemberData(nameof(GetParamData), parameters: 3)]
        public void AddTest_Theory_MemberData(decimal expected, decimal firstOp, decimal secondOp)
        {
            var sut = new Calculator();

            var res = sut.Add(firstOp, secondOp);

            Thread.Sleep(_delay);

            Assert.Equal(expected, res);
            _output.WriteLine($"Calculator was user {sut.HowManyTimesCalculatorUsed()} times.");
        }


        [Theory]
        [MemberData(nameof(GetNonParamData))]
        public void AddTest_Theory_MemberData_Two(decimal expected, decimal firstOp, decimal secondOp)
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

        #region Member data static methods

        public static IEnumerable<object[]> GetParamData(int numTests)
        {
            var allData = new List<object[]>
            {
                new object[] { 3, 2, 1 },
                new object[] {-10,  -4, -6 },
                new object[] { 0, -2, 2 }
            };

            
            return allData.Take(numTests);
        }

        public static IEnumerable<object[]> GetNonParamData()
        {
            yield return new object[] { 3, 2, 1 } ;
            yield return new object[] {  -10, -4, -6 };
            yield return new object[] {  0, -2, 2 };
        }

        #endregion
    }
}

