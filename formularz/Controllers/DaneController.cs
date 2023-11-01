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
                return View("RegistrationSuccess", dane);
            }
            else return View(dane);
        }
        public ActionResult RegistrationSuccess(Dane dane)
        {
            return View(dane);
        }
    }
}
