using Microsoft.AspNetCore.Mvc;

namespace AzureDevOpsDemo.Controllers
{
    public class DemoController2 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
