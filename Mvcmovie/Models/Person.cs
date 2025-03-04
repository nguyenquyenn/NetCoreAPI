using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 
namespace Mvcmovie.Models
{
    [Table("Persons")] // 
    public class Person
    {
        [Key]
        public required string PersonId { get; set; }
        public required string Fullname { get; set; }
        public string? Address { get; set; }
        public Person()
        {
            PersonId = string.Empty;
            Fullname = string.Empty;
            Address = string.Empty;
        }
    }
}
