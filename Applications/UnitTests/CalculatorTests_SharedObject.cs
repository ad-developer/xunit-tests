﻿using Xunit;
using Xunit.Abstractions;

namespace Applications.UnitTests
{
    public class CalculatorTests_SharedObject: IClassFixture<Calculator>
	{
		private Calculator _sut;
        private readonly ITestOutputHelper _output;
        public CalculatorTests_SharedObject(Calculator calculator, ITestOutputHelper output)
        {
			_sut = calculator;
            _output = output;
        }

        [Fact]
        public void AddTest()
        {
            var res = _sut.Add(1, 1);

            Assert.Equal(2, res);
            _output.WriteLine($"Calculator was user {_sut.HowManyTimesCalculatorUsed()} times.");
        }


        [Theory]
        [ClassData(typeof(CalculatorTestData))]
        public void AddTest_Theory_ClassData(decimal expected, decimal firstOp, decimal secondOp)
        {
            var res = _sut.Add(firstOp, secondOp);

            Assert.Equal(expected, res);
            _output.WriteLine($"Calculator was user {_sut.HowManyTimesCalculatorUsed()} times.");
        }
    }
}

