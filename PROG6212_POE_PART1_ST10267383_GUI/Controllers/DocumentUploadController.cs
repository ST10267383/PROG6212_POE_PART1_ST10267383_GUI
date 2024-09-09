using Microsoft.AspNetCore.Mvc;

namespace PROG6212_POE_PART1_ST10267383_GUI.Controllers
{
    public class DocumentUploadController : Controller //(W3Schools, 2022)
    {
        public IActionResult UploadDocument()
        {
            return View();  
        }
    }
}
