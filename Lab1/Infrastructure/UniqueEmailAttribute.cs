using Lab1.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Lab1.Infrastructure
{
    public class UniqueEmailAttribute : ValidationAttribute
    {
        private avdbContext _avdb;

        public UniqueEmailAttribute()
        {
            _avdb = new avdbContext();
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string email = value as string;

            if (email != null)
            {
                if (_avdb.Clients.Any(x => x.MobilePhoneNumber == email))
                {
                    return new ValidationResult("Client with this E-mail already exists");
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