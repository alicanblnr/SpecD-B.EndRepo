using Dominos.Dal.Abstract;
using Dominos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominos.Dal.Concrete.EntityFramework
{
    public class EfCustomerDal : ICustomerDal
    {
        private DominosContext _context = new DominosContext();
        public void Add(Customer customer)
        {
            _context.Customer.Add(customer);
            _context.SaveChanges();
        }
    }
}
