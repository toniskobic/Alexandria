using Data.Entities;

namespace Data.Repositories
{
    public class LoanItemRepository : GenericRepository<LoanItem>
    {
        public LoanItemRepository(AlexandriaContext appDbContext) : base(appDbContext)
        {
        }
    }
}
