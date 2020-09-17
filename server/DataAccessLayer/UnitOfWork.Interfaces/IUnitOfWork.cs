using System.Threading.Tasks;

namespace DataAccessLayer.UnitOfWork.Interfaces
{
    public interface IUnitOfWork
    {
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
