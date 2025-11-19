
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EfCore
{
    public class EfCoreCommetDal : EfCoreGenericRepository<ENTITY.Commet, AppDbContext> 
    {
        private readonly AppDbContext _appDbContext;


        public EfCoreCommetDal(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
