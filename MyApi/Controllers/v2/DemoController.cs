using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers.v2
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetDemo()
        {
            return Content("Hola desde la versión 2");
        }
    }
}