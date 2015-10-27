using System;
using System.ComponentModel.DataAnnotations;

namespace Lab1.Entities
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        public DateTime Birthdate { get; set; }

        [Required]
        public int? GenderId { get; set; }

        [Required]
        [StringLength(2)]
        public string PassportSerie { get; set; }

        [Required]
        [StringLength(7)]
        public string PassportNumber { get; set; }

        [Required]
        [StringLength(100)]
        public string PassportIssuingAuthority { get; set; }

        [Required]
        public DateTime IssueDate { get; set; }

        [Required]
        [StringLength(14)]
        public string IndentityNo { get; set; }

        [Required]
        public int? LocationCityId { get; set; }

        [Required]
        [StringLength(100)]
        public string LocationAddress { get; set; }

        [StringLength(13)]
        public string MobilePhoneNumber { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(100)]
        public string Work { get; set; }

        [StringLength(100)]
        public string JobPosition { get; set; }

        [Required]
        public int? RegistrationCityId { get; set; }

        [Required]
        [StringLength(100)]
        public string RegistrationAddress { get; set; }

        [Required]
        public int? MaritalStatusId { get; set; }

        [Required]
        public int? NationalityId { get; set; }

        [Required]
        public int? DisabilityId { get; set; }
        
        [Required]
        public bool Pensioner { get; set; }

        public decimal? MonthlyIncome { get; set; }

        [Required]
        public bool Liable { get; set; }

        public virtual Gender Gender { get; set; }

        public virtual City LocationCity { get; set; }

        public virtual City RegistrationCity { get; set; }

        public virtual MaritalStatus MaritalStatus { get; set; }

        public virtual Nationality Nationality { get; set; }

        public virtual Disability Disability { get; set; }

    }
}