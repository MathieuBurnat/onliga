using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using onliga.Data;
using Microsoft.EntityFrameworkCore;
namespace onliga.Controllers
{
    public class BooksController : Controller
    {
        // 
        // GET: /book/
        // GET: Books
        public async Task<IActionResult> Index()
        {
            return View(await _context.Books.ToListAsync());
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