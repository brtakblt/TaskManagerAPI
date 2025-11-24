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
    public  class UserService : IUserService
    {
        private readonly IUserDal _userDal;

        public UserService(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public async Task CreateAsync(User entity)
        {
            await _userDal.CreateAysnc(entity);
        }

        public async Task DeleteAsync(int Id)
        {
            var entitytoDelete = await _userDal.GetByIdAsync(Id);
            if (entitytoDelete == null)
            {
                throw new Exception($"Silmek istenilen {Id} ID'li kayıt bulunamadı");
            }
            else
            {
                await _userDal.DeleteAsync(Id);
            }
        }

        public async Task<IEnumerable<User>> GetAllAsync(Expression<Func<User, bool>> filter = null)
        {
            return await _userDal.GetAllAsync(filter);
        }

        public async Task<User> GetByIdAsync(int Id)
        {
            var entitytoGet = await _userDal.GetByIdAsync(Id);
            if (entitytoGet != null)
            {
                return await _userDal.GetByIdAsync(Id);

            }
            else
            {
                throw new Exception("$Getirilmek istenilen {Id} ID'li kayıt bulunamadı");
            }
        }

        public async Task UpdateAsync(User user)
        {
            await _userDal.UpdateAsync(user);
        }

        Task IRepository<User>.CreateAysnc(User entity)
        {
            throw new NotImplementedException();
        }

        Task IRepository<User>.DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<User>> IRepository<User>.GetAllAsync(Expression<Func<User, bool>> filter)
        {
            throw new NotImplementedException();
        }

        Task<User> IRepository<User>.GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        Task IRepository<User>.UpdateAsync(Project project)
        {
            throw new NotImplementedException();
        }
    }
}
