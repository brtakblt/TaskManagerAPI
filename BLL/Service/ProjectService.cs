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
    public class ProjectService: IProjectService
    {

        private readonly IProjectDal _projectdal;
      
        public ProjectService(IProjectDal projectDal)
        {
            _projectdal = projectDal;
        }

        public async Task CreateAsync(Project entity)
        {
            await _projectdal.CreateAysnc(entity);
        }

        public async Task DeleteAsync(int Id)
        {
            var entitytoDelete = await _projectdal.GetByIdAsync(Id);

            if(entitytoDelete == null)
            {
                throw new Exception($"Silmek istenilen {Id} ID'li kayıt bulunamadı");
            }
            else
            {
                await _projectdal.DeleteAsync(Id);
            }
        }

        public async Task<IEnumerable<Project>> GetAllAsync(Expression<Func<Project, bool>> filter = null)
        {
            return await _projectdal.GetAllAsync(); 
        }

        public async Task<Project> GetByIsAsync(int Id)
        {
            var entitytoGet = await _projectdal.GetByIdAsync(Id);

            if (entitytoGet != null)
            {
                return await _projectdal.GetByIdAsync(Id);
            }
            else
            {
                throw new Exception($"Getirilmek istenilen {Id} ID'li kayıt bulunamadı");
            }

        }

        public async Task UpdateAsync(Project project)
        {
            await _projectdal.UpdateAsync(project);
        }

        Task IRepository<Project>.CreateAysnc(Project entity)
        {
            throw new NotImplementedException();
        }

        Task IRepository<Project>.DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Project>> IRepository<Project>.GetAllAsync(Expression<Func<Project, bool>> filter)
        {
            throw new NotImplementedException();
        }

        Task<Project> IRepository<Project>.GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        Task IRepository<Project>.UpdateAsync(Project project)
        {
            throw new NotImplementedException();
        }
    }
}
