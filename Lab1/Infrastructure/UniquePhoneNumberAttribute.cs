using Lab1.Entities;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Lab1.Infrastructure
{
    public class UniquePhoneNumberAttribute : ValidationAttribute
    {
        private avdbContext _avdb;

        public UniquePhoneNumberAttribute()
        {
            _avdb = new avdbContext();
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string mobilePhoneNumber = value as string;

            if (mobilePhoneNumber != null)
            {
                if (_avdb.Clients.Any(x => x.MobilePhoneNumber == mobilePhoneNumber))
                {
                    return new ValidationResult("Client with this Mobile Phone already exists");
                }
                else
                {
                    return ValidationResult.Success;
                }
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}