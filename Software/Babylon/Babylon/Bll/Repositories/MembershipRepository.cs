﻿using Dll.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Repositories
{
    public class MembershipRepository : GenericRepository<Membership>
    {
        public MembershipRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
}
