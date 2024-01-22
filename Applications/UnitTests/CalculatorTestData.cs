namespace Applications.UnitTests
{
	public class CalculatorTestData : IEnumerable<object[]>
	{
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 3, 1, 2 };
            yield return new object[] { -10, -4, -6 };
            yield return new object[] { 0, -2, 2 };
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
    }
}

