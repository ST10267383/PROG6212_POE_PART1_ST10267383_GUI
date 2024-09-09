using Microsoft.AspNetCore.Mvc;

namespace PROG6212_POE_PART1_ST10267383_GUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
