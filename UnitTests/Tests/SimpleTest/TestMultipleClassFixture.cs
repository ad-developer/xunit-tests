using Applications;
using UnitTests.Fixtures;

namespace UnitTests.Tests.SimpleTest
{
    public class TestMultipleClassFixture : IClassFixture<EngineFixture>, IClassFixture<WheelFixture>
	{
        private readonly Car _sut;

        public TestMultipleClassFixture(EngineFixture engine, WheelFixture wheel)
		{
            _sut = new Car(engine, wheel, wheel, wheel, wheel);
        }

        [Fact]
        [Trait("Category", "Simple test multiple class fixtures")]
        public void StartTest()
        {
            _sut.Start();
            Assert.True(true);
        }
    }
}
