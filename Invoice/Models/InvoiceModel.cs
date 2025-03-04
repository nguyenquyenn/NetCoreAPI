using System.ComponentModel.DataAnnotations;

namespace InvoiceCalculator.Models
{
    public class InvoiceModel
    {
        [Required(ErrorMessage = "Vui lòng nhập số lượng.")]
        [Range(1, int.MaxValue, ErrorMessage = "Số lượng phải lớn hơn 0.")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập đơn giá.")]
        [Range(1, double.MaxValue, ErrorMessage = "Đơn giá phải lớn hơn 0.")]
        public double UnitPrice { get; set; }

        public double CalculateTotal()
        {
            return Quantity * UnitPrice;
        }
    }
}
