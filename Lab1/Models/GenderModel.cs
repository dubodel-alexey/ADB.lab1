using System.ComponentModel.DataAnnotations;

namespace Lab1.Models
{
    public class GenderModel
    {
        public int Id { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "Required field")]
        [StringLength(100, ErrorMessage = "Length must be less then 100")]
        [RegularExpression(@"^[a-zA-Z]+(?:[\s-][a-zA-Z]+)*$", ErrorMessage = "Invalid field.\n It must contains Latin letters, \"-\" and whitespase")]
        public string Title { get; set; }
    }
}