using Data.Entities;

namespace Data.Repositories
{
    public class RoleRepository : GenericRepository<Role>
    {
        public RoleRepository(AlexandriaContext appDbContext) : base(appDbContext)
        {
        }
    }
}
