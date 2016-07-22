using AppVeyorDemo;
using Xunit;

namespace AppVeyorDemoTests
{
    public class DemoClassTests
    {
        [Fact]
        public void MeNeverFails_should_return_true()
        {
            var c = new DemoClass();
            Assert.True(c.MeNeverFails(), "Expected true");
        }
    }
}
