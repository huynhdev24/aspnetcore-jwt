// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this

using System.ComponentModel.DataAnnotations;

namespace aspnetcore_jwt.Models
{
    public class LoginModel
    {
        [Required]
        [MaxLength(50)]
        public string? UserName { get; set; }
        [Required]
        [MaxLength(250)]
        public string? Password { get; set; }
    }
}
