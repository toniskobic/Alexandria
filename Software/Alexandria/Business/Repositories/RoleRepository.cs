using Data.Model;

namespace Business.Repositories
{
    public class RoleRepository : GenericRepository<Role>
    {
        public RoleRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
}
