using NUnit.Framework;
using UITests.Shared;

namespace UITests.iOS;

[TestFixture(TargetPlatform.iOS)]
public class MainPageTests : Shared.MainPageTests
{
    public MainPageTests(TargetPlatform platform)
        : base(platform)
        {

        }
}