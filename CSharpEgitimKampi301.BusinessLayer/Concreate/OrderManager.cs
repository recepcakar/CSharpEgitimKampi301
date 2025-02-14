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
    internal class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public void Tdelete(Order entity)
        {
           _orderDal.delete(entity);
        }

        public List<Order> TgetAll()
        {
         return _orderDal.getAll(); 
        }

        public Order TGetById(int id)
        {
            return _orderDal.GetById(id);
        }

        public void Tinsert(Order entity)
        {
            _orderDal.insert(entity);
        }

        public void Tupdate(Order entity)
        {
            _orderDal.update(entity);
        }
    }
}
