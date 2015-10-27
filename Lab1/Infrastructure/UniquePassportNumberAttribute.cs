using Lab1.Entities;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Lab1.Infrastructure
{
    public class UniquePassportNumberAttribute : ValidationAttribute
    {
        private avdbContext _avdb;

        public UniquePassportNumberAttribute()
        {
            _avdb = new avdbContext();
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            object instance = validationContext.ObjectInstance;
            string passpotSerie = instance.GetType().GetProperty("PassportSerie").GetValue(instance) as string;
            string passportNumber = value as string;

            if (passportNumber != null && passpotSerie != null)
            {
                if (_avdb.Clients.Any(x => (x.PassportNumber == passportNumber && x.PassportSerie == passpotSerie)))
                {
                    return new ValidationResult("Client with this Passport Number already exists");
                }
                else
                {
                    return ValidationResult.Success;
                }
            }
            else
            {
                return new ValidationResult(validationContext.DisplayName + " is required");
            }
        }
    }
}