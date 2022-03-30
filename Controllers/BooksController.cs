using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using onliga.Data;
using Microsoft.EntityFrameworkCore;
namespace onliga.Controllers
{
    public class BooksController : Controller
    {


        private readonly ApplicationDbContext _context;

        public BooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: books/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books
                .FirstOrDefaultAsync(m => m.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }
        // 
        // GET: /book/
        // GET: Books
        public async Task<IActionResult> Index()
        {
            return View(await _context.Books.ToListAsync());
        }

        // GET: Books/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
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