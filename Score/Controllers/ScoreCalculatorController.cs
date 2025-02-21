using Microsoft.AspNetCore.Mvc;
using ScoreCalculatorApp.Models;

namespace ScoreCalculatorApp.Controllers
{
    public class ScoreCalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(SubjectScoreModel model)
        {
            if (ModelState.IsValid)
            {
                double finalScore = model.FinalScore;
                string result;

                if (finalScore >= 8.5)
                    result = "Xuất sắc";
                else if (finalScore >= 7.0)
                    result = "Giỏi";
                else if (finalScore >= 5.5)
                    result = "Khá";
                else if (finalScore >= 4.0)
                    result = "Trung bình";
                else
                    result = "Yếu";

                ViewBag.FinalScore = finalScore.ToString("0.00");
                ViewBag.Result = result;
            }
            return View(model);
        }
    }
}
