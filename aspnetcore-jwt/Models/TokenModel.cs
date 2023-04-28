// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this

namespace aspnetcore_jwt.Models
{
    public class TokenModel
    {
        public string? AccessToken { get; set; }
        public string? RefreshToken { get; set; }
    }
}
