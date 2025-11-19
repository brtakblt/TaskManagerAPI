using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.Repositories
{
    public interface IRepository<T>
    {
        Task CreateAysnc(T entity);
        Task UpdateAsync(Project project);
        Task DeleteAsync(int Id);
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> filter = null);
        Task<T> GetByIdAsync(int Id);

    }
}
