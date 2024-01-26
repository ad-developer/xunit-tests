using Applications.UnitTests.Fixtures;
using Xunit;

namespace Applications.UnitTests
{
    public class CarTests_MultipleClassFixtures : IClassFixture<EngineFixture>, IClassFixture<Type>
    {
		private readonly Car _sut;
		public CarTests_MultipleClassFixtures(EngineFixture engine, Type type)
		{
			var frontPassenger = (IWheel)Activator.CreateInstance(type);
			var frontDriver = (IWheel)Activator.CreateInstance(type);
			var rearPassenger = (IWheel)Activator.CreateInstance(type);
			var rearDriver = (IWheel)Activator.CreateInstance(type);

			_sut = new Car(engine, frontPassenger, frontDriver, rearPassenger, rearDriver);
		}

		[Fact]
		public void StartTest()
		{
			_sut.Start();
			Assert.True(true);
		}
	}
}

