using System.ComponentModel.DataAnnotations;

namespace ScoreCalculatorApp.Models
{
    public class SubjectScoreModel
    {
        [Required(ErrorMessage = "Vui lòng nhập điểm A.")]
        [Range(0, 10, ErrorMessage = "Điểm A phải từ 0 đến 10.")]
        public double ScoreA { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập điểm B.")]
        [Range(0, 10, ErrorMessage = "Điểm B phải từ 0 đến 10.")]
        public double ScoreB { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập điểm C.")]
        [Range(0, 10, ErrorMessage = "Điểm C phải từ 0 đến 10.")]
        public double ScoreC { get; set; }

        public double FinalScore => (ScoreA * 0.6) + (ScoreB * 0.3) + (ScoreC * 0.1);
    }
}
