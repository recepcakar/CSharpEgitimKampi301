using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Abstract
{     
    //interface internal olabilir 
    public interface IGenericDal<T> where T : class // burada T class tipi olmalı kısıtlamasını getiriyoruz
    {
        void insert(T entity); // varsayılan olarak public o yüzden yazmamalıyız tek public olabiliyor zaten
         void delete(int id);
        void update(T entity);
        List<T> getAll();
        T GetById(int id);
    }
}
