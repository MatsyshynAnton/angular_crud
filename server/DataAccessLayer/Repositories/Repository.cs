using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.UnitOfWork.Interfaces;
using DataAccessLayer.Models.Abstractions;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class Repository<T> : IRepository<T>
        where T : BaseEntity
    {
        private readonly HomeworkDbContext _context;
        public Repository(HomeworkDbContext context, IUnitOfWork unitOfWork)
        {
            _context = context;
            this.unitOfWork = unitOfWork;
        }

        public virtual IUnitOfWork unitOfWork { get; }

        public virtual async Task Create(T entity)
        {
            entity.Id = 0;
            await _context.AddAsync(entity);
        }

        public virtual async Task Delete(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            _context.Remove(entity);
        }

        public virtual IQueryable<T> Get()
        {
            return _context.Set<T>().AsQueryable();
        }

        public virtual async Task<T> Get(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public virtual void Update(T updatedEntity)
        {
            _context.Entry(updatedEntity).State = EntityState.Modified;
        }
    }
}
