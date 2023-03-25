using Data.Model;

namespace Business.Repositories
{
    public class PickingInItemRepository : GenericRepository<PickingInItem>
    {
        public PickingInItemRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
}
