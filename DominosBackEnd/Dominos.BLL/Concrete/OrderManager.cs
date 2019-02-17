using Dominos.Dal.Abstract;
using Dominos.Entities;
using Dominos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominos.BLL.Concrete
{
    public class OrderManager : IOrderService
    {
        private IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }
        public void Add(Order order,List<OrderItems> orderItems)
        {
            _orderDal.Add(order,orderItems);
        }
    }
}
