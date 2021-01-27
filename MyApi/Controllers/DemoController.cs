using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetDemo()
        {
            return Content("Hola desde la versión por defecto");
        }
    }
}