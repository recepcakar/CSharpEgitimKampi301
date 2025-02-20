using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BusinessLayer.Concreate
{
    public class ProductManger : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManger(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Tdelete(Product entity)
        {
            _productDal.delete(entity);
        }

        public List<Product> TgetAll()
        {
            return _productDal.getAll();
        }

        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }

        public List<object> TGetProductsWithCategory()
        {
            return _productDal.GetProductsWithCategory();
        }

        public void Tinsert(Product entity)
        {
         _productDal.insert(entity);
        }

        public void Tupdate(Product entity)
        {
            _productDal.update(entity);  
        }
    }
}
