using Data.Entities;

namespace Data.Repositories
{
    public class ReceiptRepository : GenericRepository<Receipt>
    {
        public ReceiptRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
