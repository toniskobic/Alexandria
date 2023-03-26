using System.Data.Entity;
using System.Threading.Tasks;
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
            var user = await UnitOfWork.Users.GetAll()
                .Include(u => u.Role)
                .FirstOrDefaultAsync(u => u.UserName == username && u.Password == password);

            if (user == null)
            {
                return LoginResult.NotFound;
            }
            else if (user.Locked)
            {
                return LoginResult.Inactive;
            }
            else
            {
                LoggedUser = user;
                return LoginResult.Succesful;
            }
        }
        public static void LogOut()
        { 
            LoggedUser = null;
        }
    }
}
