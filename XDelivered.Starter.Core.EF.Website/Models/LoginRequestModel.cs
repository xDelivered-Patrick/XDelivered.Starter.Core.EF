﻿using System.ComponentModel.DataAnnotations;

namespace XDelivered.StarterKits.NgCoreEF.Modals
{
    public class LoginRequestModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}