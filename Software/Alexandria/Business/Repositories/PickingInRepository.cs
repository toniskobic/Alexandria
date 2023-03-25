using Data.Model;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Business.Repositories
{
    public class PickingInRepository : GenericRepository<PickingIn>
    {
        private AppDbContext _dbContext { get; set; }

        public PickingInRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _dbContext = _appDbContext;
        }

        public List<PickingIn> GetAllPickingsIn()
        {
            return _dbContext.PickingsIn.Include(u => u.PickingInItem).ToList();
        }

        public List<PickingInItem> GetAllPickingInItems(PickingIn pickingIn)
        {
            return _dbContext.PickingsIn.Include(u => u.PickingInItem).FirstOrDefault(p => p.Id == pickingIn.Id).PickingInItem;
        }
    }
}
