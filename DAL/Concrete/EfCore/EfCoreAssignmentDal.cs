using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EfCore
{
    public class EfCoreAssignmentDal : EfCoreGenericRepository<ENTITY.Assignment, AppDbContext>
    {
        private readonly AppDbContext _appDbContext;

        public EfCoreAssignmentDal(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
