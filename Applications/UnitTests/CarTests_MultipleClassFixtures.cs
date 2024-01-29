using Applications.UnitTests.Fixtures;
using Xunit;

namespace Applications.UnitTests
{
    public class CarTests_MultipleClassFixtures : IClassFixture<EngineFixture>, IClassFixture<WheelFixture>
    {
		private readonly Car _sut;
		public CarTests_MultipleClassFixtures(EngineFixture engine, WheelFixture wheel)
		{
			_sut = new Car(engine, wheel, wheel, wheel, wheel);
		}

		[Fact]
        [Trait("Application", "Car")]
        public void StartTest()
		{
			_sut.Start();
			Assert.True(true);
		}
	}
}

