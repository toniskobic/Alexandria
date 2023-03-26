using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IDatabaseScope
    {
        Task<int> SaveAsync();
    }
}
