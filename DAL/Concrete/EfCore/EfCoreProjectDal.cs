using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EfCore
{
    public class EfCoreProjectDal :  EfCoreGenericRepository<Project, AppDbContext>
    {
        private readonly AppDbContext _appDbContext;

        public EfCoreProjectDal(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
