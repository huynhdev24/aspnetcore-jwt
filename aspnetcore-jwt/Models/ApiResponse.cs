// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this

namespace aspnetcore_jwt.Models
{
    public class ApiResponse
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public object? Data { get; set; }
    }
}
