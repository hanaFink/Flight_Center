using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Center
{
    public interface ICustomerDAO :IBasicDB<Customer>
    {
        Customer GetCustomerByUsername(string name);
    }
}
