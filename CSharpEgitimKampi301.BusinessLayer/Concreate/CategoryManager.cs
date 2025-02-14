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
    public class CategoryManager : ICategoryService
    {

        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Tdelete(Category entity)
        {
            _categoryDal.delete(entity);
        }

        public List<Category> TgetAll()
        {
           return _categoryDal.getAll();
        }

        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void Tinsert(Category entity)
        {
            _categoryDal.insert(entity);
        }

        public void Tupdate(Category entity)
        {
            _categoryDal.update(entity);
        }
    }
}
