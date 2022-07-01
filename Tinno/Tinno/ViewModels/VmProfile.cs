using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tinno.Models;

namespace Tinno.ViewModels
{
    public class VmProfile : VmBase
    {
        public CustomUser User { get; set; }
        public IList<CustomUser> UserS { get; set; }
        public VmChangePassword VmChangePassword { get; set; }
        public VmAddPassword VmAddPassword { get; set; }
        public SocialToUser SocialToUser { get; set; }
    }
}
