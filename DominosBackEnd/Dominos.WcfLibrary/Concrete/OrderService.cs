using Dominos.BLL.Concrete;
using Dominos.Dal.Concrete.EntityFramework;
using Dominos.Entities;
using Dominos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominos.WcfLibrary.Concrete
{
    public class OrderService : IOrderService
    {
        OrderManager _orderManager = new OrderManager(new EfOrderDal());

        public void Add(Order order,List<OrderItems> orderItems)
        {
            _orderManager.Add(order,orderItems);
        }
    }
}
