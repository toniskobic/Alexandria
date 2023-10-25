using System;
using System.Data.Entity;
using System.Threading.Tasks;
using Business.Interfaces;
using Data;
using Data.Entities;
using Data.Interfaces;
using Data.Repositories;

namespace Business.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        protected AlexandriaContext AppDbContext { get; set; }

        public IGenericRepository<User> Users { get; set; }

        public IGenericRepository<PickingIn> PickingIns { get; set; }

        public IGenericRepository<Author> Authors { get; set; }

        public IGenericRepository<Category> Categories { get; set; }

        public IGenericRepository<Literature> Literatures { get; set; }

        public IGenericRepository<Loan> Loans { get; set; }

        public IGenericRepository<LoanItem> LoanItems { get; set; }

        public IGenericRepository<Membership> Memberships { get; set; }

        public IGenericRepository<PickingInItem> PickingInItems { get; set; }

        public IGenericRepository<PickingOut> PickingOuts { get; set; }

        public IGenericRepository<Receipt> Receipts { get; set; }

        public IGenericRepository<ReceiptItem> ReceiptItems { get; set; }

        public IGenericRepository<Role> Roles { get; set; }

        public IDatabaseScope DatabaseScope { get; set; }

        public UnitOfWork(AlexandriaContext dbContext)
        {
            AppDbContext = dbContext;
            Roles = new RoleRepository(AppDbContext);
            Users = new UserRepository(AppDbContext);
            PickingIns = new PickingInRepository(AppDbContext);
            Authors = new AuthorRepository(AppDbContext);
            Categories = new CategoryRepository(AppDbContext);
            Literatures = new LiteratureRepository(AppDbContext);
            Loans = new LoanRepository(AppDbContext);
            LoanItems = new LoanItemRepository(AppDbContext);
            Memberships = new MembershipRepository(AppDbContext);
            PickingInItems = new PickingInItemRepository(AppDbContext);
            PickingOuts = new PickingOutRepository(AppDbContext);
            Receipts = new ReceiptRepository(AppDbContext);
            ReceiptItems = new ReceiptItemRepository(AppDbContext);
            DatabaseScope = new DatabaseScope(AppDbContext);
        }

        public async Task<bool> IsLoanedAsync(int id)
        {
            var loanItems = (await Literatures.GetAll()
                .Include(l => l.LoanItem)
                .FirstOrDefaultAsync(l => l.Id == id)).LoanItem;
            bool isLoaned = false;

            foreach (var loanItem in loanItems)
            {
                var newLoanItem = await LoanItems.GetAll()
                    .Include(l => l.Loan)
                    .FirstOrDefaultAsync(li => li.Id == loanItem.Id);
                if (loanItem.Loan.DateReturned == null)
                {
                    isLoaned = true;
                    break;
                }
            }

            return isLoaned;
        }
    }
}
