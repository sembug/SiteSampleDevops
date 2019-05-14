using SiteSampleDevops.Controllers;
using Xunit;

namespace SiteSampleDevops.Tests
{
    public class TestController
    {
        [Fact]
        public void TestGet()
        {
            var controller = new ValuesController();

            // Act
            var actionResult = controller.Get();

            // Assert
            Assert.NotNull(actionResult);
            var messages = (string[])actionResult.Value;
            Assert.Equal(2, messages.Length);
        }
    }
}
