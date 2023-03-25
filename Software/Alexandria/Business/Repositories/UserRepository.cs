using Data.Model;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Business.Repositories
{
    public class UserRepository : GenericRepository<User>
    {
        private AppDbContext _dbContext { get; set; }

        public UserRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _dbContext = _appDbContext;
        }

        public List<User> GetAllUsers()
        {
            return _dbContext.Users.Include(u => u.Role).Include(x => x.Membership).ToList();
        }

        public User FindEmployee(string user, string password)
        {
          return _dbContext.Users.Include(u => u.Role).FirstOrDefault(u => u.UserName == user && u.Password == password);
        }

    }
}
