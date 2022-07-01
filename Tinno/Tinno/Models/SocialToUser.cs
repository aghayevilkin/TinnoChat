using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tinno.Models
{
    public class SocialToUser
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Link { get; set; }
        public int SocialId { get; set; }

        public Social Social { get; set; }

        public string UserId { get; set; }

        public CustomUser User { get; set; }
    }
}
