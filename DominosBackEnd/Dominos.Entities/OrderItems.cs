using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominos.Entities
{
   public class OrderItems
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public double ProductPrice { get; set; }
        public double ProductDiscountPrice { get; set; }
        public double DiscountValue { get; set; }

    }
}
