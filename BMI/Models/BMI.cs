using System.ComponentModel.DataAnnotations;

namespace BMIApp.Models
{
    public class BMIModel
    {
        [Required(ErrorMessage = "Vui lòng nhập cân nặng")]
        [Range(1, 500, ErrorMessage = "Cân nặng phải từ 1 đến 500 kg")]
        public float Weight { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập chiều cao")]
        [Range(0.5, 3, ErrorMessage = "Chiều cao phải từ 0.5 đến 3 mét")]
        public float Height { get; set; }

        public float BMI => Height > 0 ? Weight / (Height * Height) : 0;

        public string GetBMICategory()
        {
            if (BMI < 18.5) return "Gầy";
            if (BMI < 24.9) return "Bình thường";
            if (BMI < 29.9) return "Thừa cân";
            return "Béo phì";
        }
    }
}
