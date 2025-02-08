using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        public string CatogoryName { get; set; }
        public int CategoryId { get; set; }
        public bool CatogoryStatus { get; set; }
        public List<Product> Products { get; set; }

    }
    /*
    field=>  sınıfın içinde direkt
    variable=> bir method içinde ise
    property=> get set alırsa
     */
}

