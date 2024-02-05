using Applications;
using UnitTests.TestData;

namespace UnitTests.SimpleTest
{
    public class TestWithParameters
	{
		public TestWithParameters()
		{
		}

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(15, 5, 10)]
        [InlineData(0, -15, 15)]
        [Trait("Category", "Simple test with parameters")]
        public void AddTest_Theory_InlineData(decimal expected, decimal firstOp, decimal secondOp)
        {
            // Arrange 
            var sut = new Calculator();

            // Act
            var res = sut.Add(firstOp, secondOp);

            // Assert
            Assert.Equal(expected, res);
        }
 
        [Theory]
        [MemberData(nameof(GeDataWithParam), parameters: 3)]
        [Trait("Category", "Simple test with parameters")]
        public void AddTest_Theory_MemberData_WithParam(decimal expected, decimal firstOp, decimal secondOp)
        {
            // Arrange 
            var sut = new Calculator();

            // Act
            var res = sut.Add(firstOp, secondOp);

            // Assert
            Assert.Equal(expected, res);
        }

        [Theory]
        [MemberData(nameof(GetDataNoParam))]
        [Trait("Category", "Simple test with parameters")]
        public void AddTest_Theory_MemberData_NoParam(decimal expected, decimal firstOp, decimal secondOp)
        {
            // Arrange
            var sut = new Calculator();

            // Act
            var res = sut.Add(firstOp, secondOp);

            // Assert
            Assert.Equal(expected, res);
        }

        [Theory]
        [ClassData(typeof(CalculatorTestData))]
        [Trait("Category", "Simple test with parameters")]
        public void AddTest_Theory_ClassData(decimal expected, decimal firstOp, decimal secondOp)
        {
            // Arrange 
            var sut = new Calculator();

            // Act
            var res = sut.Add(firstOp, secondOp);

            //Assert
            Assert.Equal(expected, res);
   
        }
        #region Mmember Data Methods 

        public static IEnumerable<object[]> GeDataWithParam(int numTests)
        {
            var allData = new List<object[]>
            {
                new object[] { 3, 2, 1 },
                new object[] {-10,  -4, -6 },
                new object[] { 0, -2, 2 }
            };
            return allData.Take(numTests);
        }

        public static IEnumerable<object[]> GetDataNoParam()
        {
            yield return new object[] { 3, 2, 1 };
            yield return new object[] { -10, -4, -6 };
            yield return new object[] { 0, -2, 2 };
        }

        #endregion
    }
}

