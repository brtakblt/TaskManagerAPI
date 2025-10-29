using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EfCore
{
    public class EfCoreUserDal : EfCoreGenericRepository<User, AppDbContext>
    {
        private readonly AppDbContext? _appDbContext;

        public EfCoreUserDal(AppDbContext appDbContext): base(appDbContext)
        {
            _appDbContext = appDbContext;
        } 
    }
}
