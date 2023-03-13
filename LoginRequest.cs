﻿using System.ComponentModel.DataAnnotations;

namespace Net6AngularOauth2
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; } = null!;
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; } = null!;
        public string Url { get; set; } = null!;
    }
}