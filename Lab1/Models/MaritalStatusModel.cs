using System.ComponentModel.DataAnnotations;

namespace Lab1.Models
{
    public class MaritalStatusModel
    {
        public int Id { get; set; }

        [Display(Name = "Marital Status")]
        [Required(ErrorMessage = "Required field")]
        [StringLength(100, ErrorMessage = "Length must be less then 100")]
        [RegularExpression(@"^[a-zA-Z]+(?:[\s-][a-zA-Z]+)*$", ErrorMessage = "Invalid field.\n It must consists of Latin letters, \"-\" and whitespase")]
        public string Title { get; set; }
    }
}