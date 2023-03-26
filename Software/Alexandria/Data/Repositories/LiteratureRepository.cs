﻿using Data.Entities;

namespace Data.Repositories
{
    public class LiteratureRepository : GenericRepository<Literature>
    {
        public LiteratureRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
