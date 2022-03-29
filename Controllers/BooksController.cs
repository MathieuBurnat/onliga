using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace onliga.Controllers
{
    public class BooksController : Controller
    {
        // 
        // GET: /book/
        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /book/
        public IActionResult New()
        {
            return View();
        }

        // 
        // GET: /book/Welcome/ 
        // Requires using System.Text.Encodings.Web;

        public IActionResult Test(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}