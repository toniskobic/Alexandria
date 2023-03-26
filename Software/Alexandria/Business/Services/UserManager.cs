using Business.Enums;
using Data;
using Data.Entities;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Business.Services
{
    public static class UserManager
    {
        private static readonly UnitOfWork UnitOfWork = new UnitOfWork(new AppDbContext());

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
