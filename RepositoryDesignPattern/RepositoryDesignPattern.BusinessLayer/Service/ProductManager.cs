using RepositoryDesignPattern.BusinessLayer.Abstract;
using RepositoryDesignPattern.DataAcessLayer.Abstract;
using RepositoryDesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.BusinessLayer.Service
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _ProductDal;

        public ProductManager(IProductDal productDal)
        {
            _ProductDal = productDal;
        }

        public void TDelete(Product t)
        {
            _ProductDal.Delete(t);
        }

        public Product TGetById(int id)
        {
            return _ProductDal.GetById(id);
        }

        public List<Product> TGetList()
        {
            return _ProductDal.GetList();
        }

        public void TInsert(Product t)
        {
            _ProductDal.Add(t);
        }

        public List<Product> TProductListWithCategory()
        {
            return _ProductDal.ProductListWithCategory();
        }

        public void TUpdate(Product t)
        {
            _ProductDal.Update(t);
        }
    }
}
