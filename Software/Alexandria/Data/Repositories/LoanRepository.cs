using Data.Entities;

namespace Data.Repositories
{
    public class LoanRepository : GenericRepository<Loan>
    {
        public LoanRepository(AlexandriaContext appDbContext) : base(appDbContext)
        {
        }
    }
}
