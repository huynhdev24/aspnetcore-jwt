// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this

using System.ComponentModel.DataAnnotations;

namespace aspnetcore_jwt.Models
{
    public class Category
    {
        [Required]
        [MaxLength(50)]
        public string? CategoryName { get; set; }
    }
}
