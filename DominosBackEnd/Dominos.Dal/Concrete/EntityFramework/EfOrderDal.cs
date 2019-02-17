using Dominos.Dal.Abstract;
using Dominos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominos.Dal.Concrete.EntityFramework
{
    public class EfOrderDal : IOrderDal

    {
        private DominosContext _context = new DominosContext();
        public void Add(Order order,List<OrderItems> orderItems)
        {
            _context.Order.Add(order);
            orderItems.ForEach(o => {
                _context.OrderItems.Add(o);
            });
            
            _context.SaveChanges();
        }
    }
}
