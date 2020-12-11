using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Blazor.WASM.Enums;
using Blazor.WASM.Validation;

namespace Blazor.WASM.Models
{
    public class ContactFormDTO
    {

        [Required(ErrorMessage = "Please enter your first name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        [CannotBeTooOld]
        public DateTime DateOfJoining { get; set; }

        public string Message { get; set; }

        [Required, EnumDataType(typeof(Colour))]
        public string FavouriteColour { get; set; }

        [Required, EnumDataType(typeof(Hobby))]
        public string Hobby { get; set; }

        [Required]
        [Range(typeof(bool), "true", "true",
            ErrorMessage = "You must accept terms & conditions")]
        public bool AcceptedTerms { get; set; }

        [Range(18, 100, ErrorMessage = "Age must be between 18 and 100")]

        public int Age { get; set; }

        [PasswordPropertyText(true)]
        [Required]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords does not match")]
        public string ConfirmPassword { get; set; }

        [ValidateComplexType]
        public AddressDTO PersonalAddress { get; set; }

    }

    public class AddressDTO
    {
        [Required]
        public string AddressLine1 { get; set; }

        [Required]
        public string PostCode { get; set; }
    }
}
