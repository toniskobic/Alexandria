using Data.Entities;

namespace Data.Repositories
{
    public class ReceiptItemRepository : GenericRepository<ReceiptItem>
    {
        public ReceiptItemRepository(AlexandriaContext appDbContext) : base(appDbContext)
        {
        }
    }
}
