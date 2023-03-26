using Data.Entities;

namespace Data.Repositories
{
    public class UserRepository : GenericRepository<User>
    {
        public UserRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
