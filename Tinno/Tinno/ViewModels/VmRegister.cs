using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Tinno.Models;

namespace Tinno.ViewModels
{
    public class VmRegister : VmBase
    {
        [Required(ErrorMessage = "Name is required"), MaxLength(30)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Surname is required"), MaxLength(30)]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Email is required"), MaxLength(50)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Password is required"), MaxLength(30), MinLength(6, ErrorMessage = "Password must have a minimum length of 6")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage =
            "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public Gender Gender { get; set; }
    }
}
