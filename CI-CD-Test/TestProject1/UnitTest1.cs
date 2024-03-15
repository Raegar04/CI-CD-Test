using CI_CD_Test.Controllers;
using Microsoft.Extensions.Logging;
using Moq;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var loggerMock = new Mock<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(loggerMock.Object);

            var result = controller.Get();

            Assert.NotNull(result);
        }
    }
}