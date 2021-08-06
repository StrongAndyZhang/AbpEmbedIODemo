using ConsoleApp.Services;
using EmbedIO;
using EmbedIO.Routing;
using EmbedIO.WebApi;

namespace ConsoleApp.Controllers
{
    public class DemoController : WebApiController
    {
        private readonly IDemoService _demoService;

        public DemoController(IDemoService demoService)
        {
            _demoService = demoService;
        }

        [Route(HttpVerbs.Get, "/hello-world")]
        public string HelloWorld()
        {
            return _demoService.HelloWorld();
        }
    }
}