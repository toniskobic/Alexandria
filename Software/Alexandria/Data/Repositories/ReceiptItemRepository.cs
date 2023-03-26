using Data.Entities;

namespace Data.Repositories
{
    public class ReceiptItemRepository : GenericRepository<ReceiptItem>
    {
        public ReceiptItemRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
