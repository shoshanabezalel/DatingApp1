using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class BaseApiController : Controller
    {
        // private readonly ILogger<BaseApiController> _logger;

        // public BaseApiController(ILogger<BaseApiController> logger)
        // {
        //     _logger = logger;
        // }

        // public IActionResult Index()
        // {
        //     return View();
        // }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View("Error!");
        // }
    }
}