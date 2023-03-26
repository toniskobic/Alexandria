using Data.Entities;

namespace Data.Repositories
{
    public class UserRepository : GenericRepository<User>
    {
        public UserRepository(AlexandriaContext appDbContext) : base(appDbContext)
        {
        }
    }
}
