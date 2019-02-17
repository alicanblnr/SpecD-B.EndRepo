using Dominos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominos.Dal.Abstract
{
    public interface ICustomerDal
    {
        void Add(Customer customer);
    }
}
