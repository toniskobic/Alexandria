using System.Threading.Tasks;
using Data.Entities;
using Data.Interfaces;

namespace Business.Interfaces
{
    public interface IUnitOfWork
    {
        IGenericRepository<User> Users { get; set; }

        IGenericRepository<PickingIn> PickingIns { get; set; }

        IGenericRepository<Author> Authors { get; set; }

        IGenericRepository<Category> Categories { get; set; }

        IGenericRepository<Literature> Literatures { get; set; }

        IGenericRepository<Loan> Loans { get; set; }

        IGenericRepository<LoanItem> LoanItems { get; set; }

        IGenericRepository<Membership> Memberships { get; set; }

        IGenericRepository<PickingInItem> PickingInItems { get; set; }

        IGenericRepository<PickingOut> PickingOuts { get; set; }

        IGenericRepository<Receipt> Receipts { get; set; }

        IGenericRepository<ReceiptItem> ReceiptItems { get; set; }

        IGenericRepository<Role> Roles { get; set; }

        IDatabaseScope DatabaseScope { get; set; }

        Task<bool> IsLoanedAsync(int id);
    }
}
