using Microsoft.AspNetCore.Mvc;
using BMIApp.Models;

namespace BMI.Controllers
{
    public class BMIController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("/Views/BMICalculator/Index.cshtml");
        }

        [HttpPost]
        public IActionResult Index(BMIModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.BMI = model.BMI.ToString("0.00");
                ViewBag.Category = model.GetBMICategory();
            }
            return View("/Views/BMICalculator/Index.cshtml");
        }
    }
}
