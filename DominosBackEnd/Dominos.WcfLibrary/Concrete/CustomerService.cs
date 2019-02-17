using Dominos.BLL.Concrete;
using Dominos.Dal.Abstract;
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
    public class CustomerService : ICustomerService
    {
        CustomerManager _customerManager = new CustomerManager(new EfCustomerDal());


        public void Add(Customer customer)
        {
            _customerManager.Add(customer);
        }
    }
}
