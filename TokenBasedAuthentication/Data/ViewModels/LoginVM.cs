﻿using System.ComponentModel.DataAnnotations;

namespace TokenBasedAuthentication.Data.ViewModels
{
    public class LoginVM
    {
        [Required]
        public string? EmailAddress { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
