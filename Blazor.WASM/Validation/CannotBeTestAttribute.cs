using System;
using System.ComponentModel.DataAnnotations;

namespace Blazor.WASM.Validation
{
    public class CannotBeTooOldAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var year = ((DateTime) value).Year;
            if(year < 1965)
            {
                return new ValidationResult("Year cannot be before 1965",
                    new[] {validationContext.MemberName});
            }

            return ValidationResult.Success;
        }
    }
}
