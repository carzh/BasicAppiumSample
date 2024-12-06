using Xunit;
using Xunit.Abstractions;

namespace UITests;

public class PlatformSpecificSampleTest : BaseTest
{
	public PlatformSpecificSampleTest(ITestOutputHelper output) : base(output)
	{
	}

	[Fact]
	public void SampleTest()
	{
		App.GetScreenshot().SaveAsFile($"{nameof(SampleTest)}.png");
	}
}