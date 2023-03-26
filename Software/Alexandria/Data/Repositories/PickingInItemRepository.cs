using Data.Entities;

namespace Data.Repositories
{
    public class PickingInItemRepository : GenericRepository<PickingInItem>
    {
        public PickingInItemRepository(AppDbContext appDbContext) : base(appDbContext)
        {

        }
    }
}
