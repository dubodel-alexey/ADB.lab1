using Lab1.Entities;
using Lab1.Infrastructure;
using System;
using System.ComponentModel.DataAnnotations;

namespace Lab1.Models
{
    public class ClientModel
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Required field")]
        [StringLength(100, ErrorMessage = "Length must be less then 100")]
        [RegularExpression(@"^([ \u00c0-\u01ffa-zA-Z'\-])+$", ErrorMessage = "Invalid input.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Required field")]
        [StringLength(100, ErrorMessage = "Length must be less then 100")]
        [RegularExpression(@"^([ \u00c0-\u01ffa-zA-Z'\-])+$", ErrorMessage = "Invalid input.")]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Birthdate")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true, HtmlEncode = false)]
        [Required(ErrorMessage = "Required field")]
        public DateTime Birthdate { get; set; }

        [Required(ErrorMessage = "Required field")]
        [Display(Name = "Gender")]
        public int GenderId { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Required field")]
        [Display(Name = "Passport serie")]
        [RegularExpression(@"^[a-zA-Z]{2}$", ErrorMessage = "Must be 2 letters")]
        public string PassportSerie { get; set; }

        [Required(ErrorMessage = "Required field")]
        [Display(Name = "Passport number")]
        [RegularExpression(@"^[0-9]{7}$", ErrorMessage = "Must be 7 digits")]
        public string PassportNumber { get; set; }

        [Display(Name = "Passport Issuing Authority")]
        [Required(ErrorMessage = "Required field")]
        [StringLength(100, ErrorMessage = "Length must be less then 100")]
        [RegularExpression(@"^[a-zA-Z0-9 .,/-]*$", ErrorMessage = "Can contains letter, digits, \" \", \".\", \",\" or \"-\"")]
        public string PassportIssuingAuthority { get; set; }

        [Required(ErrorMessage = "Required field")]
        [DataType(DataType.Date)]
        [Display(Name = "Issue date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true, HtmlEncode = false)]
        public DateTime IssueDate { get; set; }

        [Required(ErrorMessage = "Required field")]
        [Display(Name = "Passport indentity No")]
        [RegularExpression(@"^[A-Z0-9]{14}$", ErrorMessage = "It should contains 14 Capital letters or digits")]
        public string IndentityNo { get; set; }

        [Required(ErrorMessage = "Required field")]
        [Display(Name = "Location City")]
        public int LocationCityId { get; set; }

        [Display(Name = "Location City")]
        public string LocationCity { get; set; }

        [Required(ErrorMessage = "Required field")]
        [Display(Name = "Location Address")]
        [StringLength(100, ErrorMessage = "Length must be less then 100")]
        [RegularExpression(@"^[a-zA-Z0-9 .,/-]*$", ErrorMessage = "Can contains letter, digits, \" \", \".\", \",\" or \"-\"")]
        public string LocationAddress { get; set; }

        [Display(Name = "Mobile phone")]
        [RegularExpression(@"^\+375[0-9]{9}$", ErrorMessage = "incorrect phone. Template: +375*********")]
        public string MobilePhoneNumber { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(100)]
        public string Email { get; set; }

        [Display(Name = "Job place")]
        [StringLength(100, ErrorMessage = "Length must be less then 100")]
        [RegularExpression("^[a-zA-Z0-9 .,/-]*$", ErrorMessage = "Can contains letter, digits, \" \", \".\", \",\" or \"-\"")]
        public string Job { get; set; }

        [Display(Name = "Job position")]
        [StringLength(100, ErrorMessage = "Length must be less then 100")]
        [RegularExpression("^[a-zA-Z0-9 .,/-]*$", ErrorMessage = "Can contains letter, digits, \" \", \".\", \",\" or \"-\"")]
        public string JobPosition { get; set; }
        
        [Required(ErrorMessage = "Required field")]
        [Display(Name = "Registration City")]
        public int RegistrationCityId { get; set; }

        [Display(Name = "Registration City")]
        public string RegistrationCity { get; set; }

        [Required(ErrorMessage = "Required field")]
        [Display(Name = "Registration Address")]
        [StringLength(100, ErrorMessage = "Length must be less then 100")]
        [RegularExpression(@"^[a-zA-Z0-9 .,/-]*$", ErrorMessage = "Can contains letter, digits, \" \", \".\", \",\" or \"-\"")]
        public string RegistrationAddress { get; set; }

        [Required(ErrorMessage = "Required field")]
        [Display(Name = "Marital Status")]
        public int MaritalStatusId { get; set; }

        [Display(Name = "Marital Status")]
        public string MaritalStatus { get; set; }
        
        [Required(ErrorMessage = "Required field")]
        [Display(Name = "Nationality")]
        public int NationalityId { get; set; }

        [Display(Name = "Nationality")]
        public string Nationality { get; set; }

        [Required(ErrorMessage = "Required field")]
        [Display(Name = "Disability")]
        public int DisabilityId { get; set; }

        [Display(Name = "Disability")]
        public string Disability { get; set; }

        [Required(ErrorMessage = "Required field")]
        [Display(Name = "Pensioner")]
        public bool Pensioner { get; set; }

        [Display(Name = "Monthly Income")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Should contains only numbers")]
        public decimal? MonthlyIncome { get; set; }

        [Required(ErrorMessage = "Required field")]
        [Display(Name = "Liable")]
        public bool Liable { get; set; }
    }
}