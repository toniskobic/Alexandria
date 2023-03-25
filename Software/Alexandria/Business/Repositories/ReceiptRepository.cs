using Data.Model;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Business.Repositories
{
    public class ReceiptRepository : GenericRepository<Receipt>
    {
        private AppDbContext _dbContext { get; set; }

        public ReceiptRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _dbContext = _appDbContext;
        }

        public List<Receipt> GetAllReceipts()
        {
            return _dbContext.Receipts.Include(x => x.User).Include(x => x.Employee).ToList();
        }
        public List<ReceiptItem> GetAllReceiptItems(Receipt receipt)
        {
            return _dbContext.Receipts.Include(x => x.ReceiptItem).FirstOrDefault(x => x.Id == receipt.Id).ReceiptItem;
        }
    }
}
