using System;
using System.Security.Cryptography;
using System.Data.Entity;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Business.Enums;
using Business.Interfaces;
using Data;
using Data.Entities;

namespace Business.Services
{
    public static class UserManager
    {
        private static readonly IUnitOfWork UnitOfWork = new UnitOfWork(new AlexandriaContext());

        public static User LoggedUser { get; private set; }

        public async static Task<LoginResult> LogInUserAsync(string username, string password)
        {
            var user = await UnitOfWork.Users
                .GetAll()
                .Include(u => u.Role)
                .FirstOrDefaultAsync(u => u.UserName == username);

            if (user == null)
            {
                return LoginResult.NotFound;
            }

            var hashedPassword = HashPasword(password, user.PasswordSalt);
            if (hashedPassword == user.PasswordHash)
            {
                if (user.Locked)
                {
                    return LoginResult.Inactive;
                }
                else
                {
                    LoggedUser = user;
                    return LoginResult.Succesful;
                }
            }

            return LoginResult.Unsuccesful;
        }

        public static void LogOut()
        {
            LoggedUser = null;
        }

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
