using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace onliga.Controllers
{
    public class BookController : Controller
    {
        // 
        // GET: /book/

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /book/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}