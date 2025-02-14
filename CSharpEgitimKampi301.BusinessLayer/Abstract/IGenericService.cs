using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void Tinsert(T entity); // varsayılan olarak public o yüzden yazmamalıyız tek public olabiliyor zaten
        void Tdelete(T entity);
        void Tupdate(T entity);
        List<T> TgetAll();
        T TGetById(int id);
    }
}
