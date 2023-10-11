using Microsoft.AspNetCore.Mvc;

namespace TaskWebApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetContentAsync()
        {
            // 5. thread

            var myTask = new HttpClient().GetStringAsync("http://www.google.com");

            //

            var data = await myTask;

            return Ok(data);
        }
    }
}
