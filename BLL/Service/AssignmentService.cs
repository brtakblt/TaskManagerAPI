using DAL.Abstract;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class AssignmentService
    {
        private readonly IAssignmentDal _assignmentDal;

        public AssignmentService(IAssignmentDal assignmentDal)
        {
            _assignmentDal = assignmentDal;
        }


        public async Task CreateAsync(Assignment entity)
        {
            await _assignmentDal.CreateAysnc(entity);
        }

        public async Task DeleteAsync(int Id)
        {

            var entityToDelete = await _assignmentDal.GetByIdAsync(Id);

            if(entityToDelete ==null)
            {
                throw new Exception($"Silmek istenilen {Id} ID'li kayıt bulunamadı");
            }  
            else
            {
                await _assignmentDal.DeleteAsync(Id);
            }
        }


    }
}
