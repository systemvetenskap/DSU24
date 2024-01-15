using Microsoft.AspNetCore.Mvc;

namespace DSU24.Controllers
{
    public class SportController : Controller
    {
        //[Route("/erik")]
        public IActionResult Index()
        {
            // hämta data från api
            // manipulera data
            // lägg på annan info
            // skicka till användern i vyn
            return View();
        }
    }
}
