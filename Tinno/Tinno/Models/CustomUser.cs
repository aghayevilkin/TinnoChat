using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tinno.Models
{
    public class CustomUser : IdentityUser
    {
        [Required(ErrorMessage = "Name boş olmamalıdır!"), MaxLength(30)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Surname boş olmamalıdır!"), MaxLength(30)]
        public string Surname { get; set; }
        public string Image { get; set; }
        [Required]
        public bool IsVerify { get; set; }
        
        [Required]
        public bool IsActive { get; set; }


        public string Profision { get; set; }
        public string About { get; set; }
        public string Adress { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }

        [NotMapped]
        public IFormFile ImageFileTwo { get; set; }

        public List<SocialToUser> SocialToUsers { get; set; }

    }
}
