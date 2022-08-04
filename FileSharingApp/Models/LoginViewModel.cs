using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using FileSharingApp.Resources;



namespace FileSharingApp.Models
{
    public class LoginViewModel
    {
     [EmailAddress(ErrorMessageResourceName ="Email",ErrorMessageResourceType =typeof(SharedResource))]
      [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(SharedResource))]
        [Display(Name = "EmailLabel", ResourceType = typeof(SharedResource))]

        public string Email { get; set; }

     [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(SharedResource))]
        [DataType(DataType.Password)]
        [Display(Name = "PasswordLabel", ResourceType = typeof(SharedResource))]
        public string Password { get; set; }
    }


    public class RegisterViewModel
    {
        [EmailAddress(ErrorMessageResourceName ="Email",ErrorMessageResourceType =typeof(SharedResource))]
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(SharedResource))]
         [Display(Name ="EmailLabel",ResourceType =typeof(SharedResource))]
        public string Email { get; set; }

        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(SharedResource))]
        [DataType(DataType.Password)]
        [Display(Name = "PasswordLabel", ResourceType = typeof(SharedResource))]
        public string Password { get; set; }

        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(SharedResource))]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [Display(Name = "ConfirmPasswordLabel", ResourceType = typeof(SharedResource))]
        public string ConfirmPassword { get; set; }
        public string LastName { get;  set; }
        public string FirstName { get;  set; }
    }

    public class ChangePasswordViewModel
    {

        [Required]
        public string CurrentPassword { get; set; }
        [Required]
        public string NewPassword { get; set; }
        [Required]
        [Compare("NewPassword")]
        public string ConfirmPassword { get; set; }
    }


    public class AddPasswordViewModel
    {

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
     
    }
}
