using Bll.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Services
{
    public class UnitOfWork
    {
        protected AppDbContext _appDbContext { get; set; }
        public UserRepository Users { get; set; }
        public PickingInRepository PickingIns { get; set; }

        public UnitOfWork(AppDbContext dbContext)
        {
            Users = new UserRepository(_appDbContext);
            PickingIns = new PickingInRepository(_appDbContext);
            _appDbContext = dbContext;
        }

        public int Complete()
        {
            return _appDbContext.SaveChanges();
        }
    }
}
