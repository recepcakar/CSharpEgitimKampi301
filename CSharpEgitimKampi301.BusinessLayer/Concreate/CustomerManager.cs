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
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Tdelete(Customer entity)
        {
            _customerDal.delete(entity);
        }

        public List<Customer> TgetAll()
        {
            return _customerDal.getAll();
        }

        public Customer TGetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public void Tinsert(Customer entity)
        {
            if (entity.CustomerName != "" && entity.CustomerName.Length >= 3 && entity.CustomerSurname != ""
                 && entity.CustomerSurname.Length >= 3)
            {
                //ekleme yap
            }
            else
            {
                //hata mesajı ver
            }
        }

        public void Tupdate(Customer entity)
        {
            if (entity.CustomerId != 0)
            {
                _customerDal.update(entity);
            }
            else
            {
                //hata mesajı ver
            }
        }
    }
}
