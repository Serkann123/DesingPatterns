using Microsoft.EntityFrameworkCore;
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
    public class EFProductDal : GenericRepository<Product>, IProductDal
    {
        private readonly Context _context;
        public EFProductDal(Context context) : base(context)
        {
            _context = context;
        }

        public List<Product> ProductListWithCategory()
        {
            return _context.Products.Include(x => x.Category).ToList();
        }
    }
}
