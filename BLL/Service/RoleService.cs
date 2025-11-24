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
    public class RoleService :IRoleService
    {
        private readonly IRoleDal _roleDal;

        public RoleService(IRoleDal roleDal)
        {
            roleDal = _roleDal;
        }

        public async Task CreateAsync(Role entity)
        {
            await _roleDal.CreateAysnc(entity);
        }

        public async Task DeleteAsync(int Id)
        {
            var entitytoDelete = await _roleDal.GetByIdAsync(Id);

            if(entitytoDelete == null)
            {
                throw new Exception($"Silinmek istenen {Id} ID'li kayıt bulunamadı");
            }
            else
            {
                await _roleDal.DeleteAsync(Id);
            }
        }
        public async Task<IEnumerable<Role>> GetAllAsync(Expression<Func<Role, bool>> filter = null)
        {
            return await _roleDal.GetAllAsync(filter);
        }
        
        public async Task<Role> GetByIdAsync(int Id)
        {
            var entitytoGet = await _roleDal.GetByIdAsync(Id);
            if (entitytoGet != null)
            {
                return await _roleDal.GetByIdAsync(Id);
            }
            else
            {
                throw new Exception($"Getirilmek istenilen {Id} ID'li kayıt bulunamadı");
            }
        }

        public async Task UpdateAsync(Role role)
        {
            await _roleDal.UpdateAsync(role);
        }

        Task IRepository<Role>.CreateAysnc(Role entity)
        {
            throw new NotImplementedException();
        }

        Task IRepository<Role>.DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Role>> IRepository<Role>.GetAllAsync(Expression<Func<Role, bool>> filter)
        {
            throw new NotImplementedException();
        }

        Task<Role> IRepository<Role>.GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        Task IRepository<Role>.UpdateAsync(Project project)
        {
            throw new NotImplementedException();
        }
    }
}
