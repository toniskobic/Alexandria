using Data.Entities;

namespace Data.Repositories
{
    public class PickingOutRepository : GenericRepository<PickingOut>
    {
        public PickingOutRepository(AlexandriaContext dbContext) : base(dbContext)
        {
        }
    }
}
