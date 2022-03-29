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

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}