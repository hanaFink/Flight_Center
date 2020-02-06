using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Center
{
    public interface ICustomerDAO :IBasicDB<Customers>
    {
        Customers GetCustomerByUsername(string name);
    }
}
