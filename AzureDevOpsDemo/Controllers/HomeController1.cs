using Microsoft.AspNetCore.Mvc;

namespace AzureDevOpsDemo.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View("this is the text");
        }
    }
}
