using System.Threading.Tasks;

namespace SimpleFarmLog.Repositories
{
    public interface IUnitOfWork
    {
        void Dispose();
        int Save();
        Task<int> SaveAsync();
    }
}