using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;

namespace LoginFormASPCore6.Models
{
    public partial class UserTbl
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Gender { get; set; } = null!;

        [Required]
        public int? Age { get; set; }

        [Required]
        public string Email { get; set; } = null!;

        [Required]
        public string Password { get; set; } = null!;
    }
}
