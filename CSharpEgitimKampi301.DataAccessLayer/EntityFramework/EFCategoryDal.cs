using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Context;
using CSharpEgitimKampi301.DataAccessLayer.Repostories;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.EntityFramework
{
    public class EFCategoryDal:GenericRepository<Category>,ICategoryDal 
    {
        KampContext kampContext = new KampContext();
        private readonly DbSet<Category> _object;
        public EFCategoryDal()
        {
            _object = _object = kampContext.Set<Category>();
        }
        public virtual Category GetById(int id)
        {
           var values= _object.Where(x=>x.CategoryId == id).FirstOrDefault();
            return values;

        }
    }
}
