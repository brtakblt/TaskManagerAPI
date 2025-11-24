using BLL.Abstract;
using DAL.Abstract;
using ENTITY;
using ENTITY.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class CommetService :ICommetService
    {
        private readonly ICommetDal _commetDal;

        public CommetService(ICommetDal commetDal)
        {
            _commetDal = commetDal;
        }


      public async Task CreateAsync(Commet entity)
        {
            await _commetDal.CreateAysnc(entity);
        }

       public async Task DeleteAsync(int Id)
        {
            await _commetDal.DeleteAsync(Id);
        }

        public async Task<IEnumerable<Commet>> GetAllAsync(Expression<Func<Commet, bool>>filter = null)
        {
            return await _commetDal.GetAllAsync(filter);
        }

        public async Task<Commet> GetById(int Id)
        {
            return await _commetDal.GetByIdAsync(Id);
        }
        
        public async Task UpdateAsync(Commet entity)
        {
            await _commetDal.UpdateAsync(entity);
        }

        Task IRepository<Commet>.CreateAysnc(Commet entity)
        {
            throw new NotImplementedException();
        }

        Task IRepository<Commet>.DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Commet>> IRepository<Commet>.GetAllAsync(Expression<Func<Commet, bool>> filter)
        {
            throw new NotImplementedException();
        }

        Task<Commet> IRepository<Commet>.GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        Task IRepository<Commet>.UpdateAsync(Project project)
        {
            throw new NotImplementedException();
        }
    }
}
