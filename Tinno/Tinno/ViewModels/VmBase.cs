using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tinno.Models;

namespace Tinno.ViewModels
{
    public class VmBase
    {
        public VmLogin LoginViewModel { get; set; }
        public VmRegister RegisterViewModel { get; set; }

        public List<Social> Socials { get; set; }
        public List<Message> Messages { get; set; }
        public List<CustomUser> CustomUsers { get; set; }
        public CustomUser Customuser { get; set; }


        public string ReturnUrl { get; set; }
        public IList<AuthenticationScheme> ExternalLogins { get; set; }
    }
}
