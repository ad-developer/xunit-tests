using System;
using Xunit;
using Xunit.Abstractions;

namespace Applications.UnitTests
{

    [CollectionDefinition(name:"Guid Generator")]
    public class GuidGeneratorDefinition : ICollectionFixture<GuidGenerator> { }


    [Collection(name: "Guid Generator")]
	public class GuidGeneratorTestOne 
	{
        private readonly GuidGenerator _guidGenerator;
        private readonly ITestOutputHelper _output;
        public GuidGeneratorTestOne(ITestOutputHelper output, GuidGenerator guidGenerator)
		{
            _output = output;
            _guidGenerator = guidGenerator;

        }

        [Fact]
        void GuidTest()
        {
            var guid = _guidGenerator.RandomGuid;
            _output.WriteLine($"The guid is {guid}");
        }
	}

    [Collection(name: "Guid Generator")]
    public class GuidGeneratorTestTwo
    {
        private readonly GuidGenerator _guidGenerator;
        private readonly ITestOutputHelper _output;
        public GuidGeneratorTestTwo(ITestOutputHelper output, GuidGenerator guidGenerator)
        {
            _output = output;
            _guidGenerator = guidGenerator;

        }


        [Fact]
        void GuidTest()
        {
            var guid = _guidGenerator.RandomGuid;
            _output.WriteLine($"The guid is {guid}");
        }
    }
}

