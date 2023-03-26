using Data.Entities;

namespace Data.Repositories
{
    public class PickingOutRepository : GenericRepository<PickingOut>
    {
        public PickingOutRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
