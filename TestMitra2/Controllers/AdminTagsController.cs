using Microsoft.AspNetCore.Mvc;

namespace TestMitra2.Controllers
{
    public class AdminTagsController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
