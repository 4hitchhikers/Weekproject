using System;
using System.ComponentModel.DataAnnotations;

namespace WeekProject.Models
{
    public class RegisterViewModel
    {
        [Required]
        [MinLength(2)]
        [Display(Name = "First Name")]
        public string FirstName {get; set;}
        [Required]
        [MinLength(2)]
        [Display(Name = "Last Name")]
        public string LastName {get; set;}
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email {get; set;}
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password {get; set;}
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Passwords are not the same")]
        public string CfPassword {get; set;}
    }
}