using System.ComponentModel.DataAnnotations;

namespace Lab1.Models
{
    public class CityModel
    {
        public int Id { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "Required field")]
        [StringLength(100, ErrorMessage = "Length must be less then 100")]
        [RegularExpression(@"^[a-zA-Z]+(?:[\s-][a-zA-Z]+)*$", ErrorMessage = "Invalid field.\n It must consists of Latin letters, \"-\" and \" \"")]
        public string Title { get; set; }
    }
}