using ENTITY;
using ENTITY.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IRoleDal : IRepository<Role>
    {
        Task UpdateAsync(Role role);
    }
}
