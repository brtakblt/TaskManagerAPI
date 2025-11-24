
using ENTITY.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EfCore
{
    public class EfCoreGenericRepository<T,TContext> 

        where T : class
        where TContext : AppDbContext
    {
        private readonly AppDbContext _appdbcontext;

        public EfCoreGenericRepository(AppDbContext appDbContext)
        {
            _appdbcontext = appDbContext;
        }

        public async Task CreateAsync(T entity)
        {
            await _appdbcontext.Set<T>().AddAsync(entity);
            await _appdbcontext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _appdbcontext.Set<T>().Update(entity);
            await _appdbcontext.SaveChangesAsync();


        }

        public async Task DeleteAsync(int id)
        {
            var role = await _appdbcontext.Set<T>().FindAsync(id);
            if(role != null)
            {
                _appdbcontext.Set<T>().Remove(role);
                await _appdbcontext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T,bool>> filter = null)
        {
            if (filter == null)
            {
                return await _appdbcontext.Set<T>().ToListAsync();
            }
            else
            {
                return await _appdbcontext.Set<T>().Where(filter).ToListAsync();
            }
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _appdbcontext.Set<T>().FindAsync(id);
        }
       

    }
}
