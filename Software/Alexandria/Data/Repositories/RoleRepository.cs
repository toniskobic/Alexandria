using Data.Entities;

namespace Data.Repositories
{
    public class RoleRepository : GenericRepository<Role>
    {
        public RoleRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
