using Dll.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Repositories
{
    public class ReceiptRepository : GenericRepository<Receipt>
    {
        public ReceiptRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
}
