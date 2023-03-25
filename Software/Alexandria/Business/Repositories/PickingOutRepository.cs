using Data.Model;

namespace Business.Repositories
{
    public class PickingOutRepository : GenericRepository<PickingOut>
    {
        public PickingOutRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
}
