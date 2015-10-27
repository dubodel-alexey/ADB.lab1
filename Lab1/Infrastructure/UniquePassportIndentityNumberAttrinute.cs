using Lab1.Entities;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Lab1.Infrastructure
{
    public class UniqueIndentityNumberAttrinute : ValidationAttribute
    {
        private avdbContext _avdb;

        public UniqueIndentityNumberAttrinute()
        {
            _avdb = new avdbContext();
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string indentityNo = value as string;

            if (indentityNo != null)
            {
                if (_avdb.Clients.Any(x => x.IndentityNo == indentityNo))
                {
                    return new ValidationResult("Client with this Indentity Number already exists");
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