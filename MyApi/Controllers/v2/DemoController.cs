using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers.v2
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("2.0")]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetDemo()
        {
            return Content("Hola desde la versión 2");
        }
    }
}