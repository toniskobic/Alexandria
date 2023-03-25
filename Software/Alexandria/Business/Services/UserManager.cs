using Business.Enums;
using Data.Model;

namespace Business.Services
{
    public static class UserManager
    {
        private static readonly UnitOfWork UnitOfWork = new UnitOfWork(new AppDbContext());

        public static User LoggedUser { get; private set; }

        public static LoginResult LogInUser(string username, string password)
        {
            var user = UnitOfWork.Users.FindEmployee(username, password);

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
