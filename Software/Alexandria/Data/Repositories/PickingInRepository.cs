using Data.Entities;

namespace Data.Repositories
{
    public class PickingInRepository : GenericRepository<PickingIn>
    {
        public PickingInRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
