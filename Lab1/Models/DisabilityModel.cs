using System.ComponentModel.DataAnnotations;

namespace Lab1.Models
{
    public class DisabilityModel
    {
        public int Id { get; set; }

        [Display(Name = "Disability")]
        [Required(ErrorMessage = "Required field")]
        [StringLength(100, ErrorMessage = "Length must be less then 100")]
        [RegularExpression(@"^[a-zA-Z0-9]+(?:[\s][a-zA-Z0-9]+)*$", ErrorMessage = "Invalid field.\n It must consists of Latin letters, numbers and whitespase")]
        public string Title { get; set; }
    }
}