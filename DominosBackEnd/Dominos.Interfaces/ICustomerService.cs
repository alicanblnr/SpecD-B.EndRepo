using Dominos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Dominos.Interfaces
{
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        void Add(Customer customer);
    }
}
