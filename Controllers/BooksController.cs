using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Collections.Generic;
using System.Linq;
using onliga.Data;
using onliga.Models;
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

        // GET: Books/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Books/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,ReleaseDate,Genre")] Book Book)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Book);
                await _context.SaveChangesAsync();

                @TempData["queryType"] = "true";
                @TempData["queryMessage"] = Book.Title +" has been created 👌";
                
                return RedirectToAction(nameof(Index));
            }
            return View(Book);
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

        // POST: Books/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ReleaseDate,Genre")] Book book)
        {
            if (id != book.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(book);
                    await _context.SaveChangesAsync();

                    @TempData["queryType"] = "true";
                    @TempData["queryMessage"] = book.Title +" has been edited 👌";
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        // GET: Books/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Book = await _context.Books
                .FirstOrDefaultAsync(m => m.Id == id);
            if (Book == null)
            {
                return NotFound();
            }

            return View(Book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var Book = await _context.Books.FindAsync(id);
            _context.Books.Remove(Book);
            await _context.SaveChangesAsync();
            
            @TempData["queryType"] = "false";
            @TempData["queryMessage"] = Book.Title +" has been deleted 💀";

            return RedirectToAction(nameof(Index));
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

        [HttpPost, ActionName("test")]
        public ActionResult Test()
        {
            @ViewData["queryType"] = "true";
            @ViewData["queryMessage"] = "My message";
            return View();
        }
    }
}