using Data.Model;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Business.Repositories
{
    public class ReceiptItemRepository : GenericRepository<ReceiptItem>
    {
        private AppDbContext _dbContext { get; set; }

        public ReceiptItemRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _dbContext = _appDbContext;
        }

        public List<ReceiptItem> GetAllReceiptItems()
        {
            return _dbContext.ReceiptItems.Include(x => x.Loan).Include(x => x.Receipt).ToList();
        }
    }
}
