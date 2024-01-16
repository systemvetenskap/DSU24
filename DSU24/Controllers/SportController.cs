using DSU24.Models;
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
            var model = new DisplaySportViewModel();
            // cors
            model.Name = "Cykel";
            return View(model);
        }
        //[Route("sport/{id}")]
        //public IActionResult Index(int id)
        //{
        //    // hämta data från api
        //    // manipulera data
        //    // lägg på annan info
        //    // skicka till användern i vyn
        //    var model = new DisplaySportViewModel();
        //    // cors
        //    model.Name = "Cykel";
        //    return View(model);
        //}

      
        public IActionResult New()
        {
            var model = new NewSportViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult New(NewSportViewModel model)
        {
            if (ModelState.IsValid)
            {
                // spara
                return Content("Din post har sparats");
            }
            return View(model);
        }
    }
}
