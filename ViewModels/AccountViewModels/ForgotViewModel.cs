﻿using System.ComponentModel.DataAnnotations;

namespace Vidly2.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
