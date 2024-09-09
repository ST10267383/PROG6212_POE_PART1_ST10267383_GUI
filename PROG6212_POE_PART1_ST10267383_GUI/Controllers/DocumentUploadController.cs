using Microsoft.AspNetCore.Mvc;

namespace PROG6212_POE_PART1_ST10267383_GUI.Controllers
{
    public class DocumentUploadController : Controller
    {
        public IActionResult UploadDocument()
        {
            return View();  // Will render Views/DocumentUpload/UploadDocument.cshtml
        }
    }
}
