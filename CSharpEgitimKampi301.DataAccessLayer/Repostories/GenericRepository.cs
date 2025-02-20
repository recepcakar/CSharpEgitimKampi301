using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Repostories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        KampContext kampContext=new KampContext();
        private readonly DbSet<T> _object;    
        public GenericRepository()
        {
            
            _object = kampContext.Set<T>();
        }
        public void delete(T entity)
        {
            var deletedEntity=kampContext.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            kampContext.SaveChanges();
        }

        public List<T> getAll()
        { 
           return _object.ToList();
        }
        

        public virtual T GetById(int id)
        {
        
            return _object.Find(id); ;
        }

        public void insert(T entity)
        {
            var addedEntity=kampContext.Entry(entity);
            addedEntity.State = EntityState.Added;
            kampContext.SaveChanges();
        }

        public void update(T entity)
        {  var updatedEntity=kampContext.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            kampContext.SaveChanges();
        }
    }
}
