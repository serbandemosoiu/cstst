using Microsoft.AspNetCore.Mvc;
using OnboardingForm.Models;

namespace OnboardingForm.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(OnboardingModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Save onboarding data to database or perform other actions

            return RedirectToAction("Confirmation");
        }

        public IActionResult Confirmation()
        {
            return View();
        }
    }
}
