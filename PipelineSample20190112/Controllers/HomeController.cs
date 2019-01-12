using Microsoft.AspNetCore.Mvc;

namespace PipelineSample20190112.Controllers
{
    public class HomeController: Controller
    {
        [Route("")]
        [Route("Home")]
        public string Index()
        {
            return "hello world!!";
        }
    }
}