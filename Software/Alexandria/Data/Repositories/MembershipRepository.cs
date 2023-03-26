using Data.Entities;

namespace Data.Repositories
{
    public class MembershipRepository : GenericRepository<Membership>
    {
        public MembershipRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
