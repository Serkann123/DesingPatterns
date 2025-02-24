using RepositoryDesignPattern.DataAcessLayer.Abstract;
using RepositoryDesignPattern.DataAcessLayer.Concrete;
using RepositoryDesignPattern.DataAcessLayer.Repositories;
using RepositoryDesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.DataAcessLayer.EntityFramework
{
    public class EFCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EFCategoryDal(Context context) : base(context)
        {
        }
    }
}
