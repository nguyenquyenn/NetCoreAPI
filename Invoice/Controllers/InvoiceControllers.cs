using InvoiceCalculator.Models;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceCalculator.Controllers
{
    public class InvoiceController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(InvoiceModel model)
        {
            if (ModelState.IsValid)
            {
                double total = model.CalculateTotal();
                ViewBag.Result = $"Tổng tiền hóa đơn: {total:C}";
            }
            return View(model);
        }
    }
}
