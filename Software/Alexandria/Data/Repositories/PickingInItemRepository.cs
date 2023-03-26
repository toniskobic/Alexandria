using Data.Entities;

namespace Data.Repositories
{
    public class PickingInItemRepository : GenericRepository<PickingInItem>
    {
        public PickingInItemRepository(AlexandriaContext appDbContext) : base(appDbContext)
        {

        }
    }
}
