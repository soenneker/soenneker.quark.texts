using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Texts.Tests;

[Collection("Collection")]
public sealed class TextTests : FixturedUnitTest
{
    public TextTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {
        // Text is now a Razor component, so integration tests would be more appropriate
        // This test serves as a placeholder for future component testing
    }
}
