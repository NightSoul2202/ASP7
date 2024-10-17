using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace ASP7.Controllers
{
    public class FileController : Controller
    {

        public FileController() { }

        
        public IActionResult DownloadFile() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult DownloadFile(string firstName, string lastName, string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                fileName = "defaultFileName";
            }

            string fileContent = $"Ім'я: {firstName}\nПрізвище: {lastName}";
            byte[] byteArray = Encoding.UTF8.GetBytes(fileContent);

            return File(byteArray, "text/plain", $"{fileName}.txt");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
