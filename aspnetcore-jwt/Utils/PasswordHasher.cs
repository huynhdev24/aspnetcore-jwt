// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this

using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;

namespace aspnetcore_jwt.Utils
{
    public class PasswordHasher
    {
        public static string Hashed(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(128 / 8); // divide by 8 to convert bits to bytes

            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                                                    password: password,
                                                    salt: salt,
                                                    prf: KeyDerivationPrf.HMACSHA256,
                                                    iterationCount: 100000,
                                                    numBytesRequested: 256 / 8));
            return hashed;
        }
    }
}
