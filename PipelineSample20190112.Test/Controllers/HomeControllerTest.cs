using PipelineSample20190112.Controllers;
using Xunit;

namespace PipelineSample20190112.Test.Controllers
{
    public class HomeControllerTest
    {
        private readonly HomeController _controller;

        public HomeControllerTest()
        {
            _controller = new HomeController();
        }

        [Fact]
        public void Index_ReturnStringValue()
        {
            Assert.IsType<string>(_controller.Index());
            Assert.NotNull(_controller.Index());
        }
    }
}