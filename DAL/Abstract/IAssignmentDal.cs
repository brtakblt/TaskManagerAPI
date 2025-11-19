using ENTITY;
using ENTITY.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IAssignmentDal : IRepository<Assignment>
    {
        
        Task UpdateAsync(Assignment assignment);
    }
}
