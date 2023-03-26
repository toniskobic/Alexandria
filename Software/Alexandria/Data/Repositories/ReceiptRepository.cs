using Data.Entities;

namespace Data.Repositories
{
    public class ReceiptRepository : GenericRepository<Receipt>
    {
        public ReceiptRepository(AlexandriaContext appDbContext) : base(appDbContext)
        {
        }
    }
}
