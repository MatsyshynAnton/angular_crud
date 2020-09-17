using DataAccessLayer.UnitOfWork.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Interfaces
{
    public interface IRepository<T> 
        where T:class
    {
        IUnitOfWork unitOfWork { get; }
        IQueryable<T> Get();
        Task<T> Get(int id);
        Task Create(T entity);
        void Update(T updatedEntity);
        Task Delete(int id);
    }
}
