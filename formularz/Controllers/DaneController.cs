using Microsoft.AspNetCore.Mvc;
using formularz.Models;

namespace formularz.Controllers
{
    public class DaneController : Controller
    {
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Form(Dane dane)
        {
            if (ModelState.IsValid)
            {
                return View("Wynik", dane);
            }
            else return View();
        }
        public IActionResult Wynik(Dane dane)
        {
            return View(dane);
        }
    }
}
