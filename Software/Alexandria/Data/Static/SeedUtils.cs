using System;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace Data.Static
{
    public static class SeedUtils
    {
        public static string HashPasword(string password, string salt)
        {
            var hash = KeyDerivation.Pbkdf2(
                password: password,
                salt: Convert.FromBase64String(salt),
                prf: KeyDerivationPrf.HMACSHA512,
                iterationCount: 350000,
                numBytesRequested: 256 / 8);

            return Convert.ToBase64String(hash);
        }

        public static string CreateSalt()
        {
            var bytes = new byte[128 / 8];
            var rng = RandomNumberGenerator.Create();
            rng.GetBytes(bytes);

            return Convert.ToBase64String(bytes);
        }
    }
}
