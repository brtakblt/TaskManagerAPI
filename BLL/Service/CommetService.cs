using DAL.Abstract;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class CommetService
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


    }
}
