using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Center
{
    interface IAirlineDAO:IBasicDB<AirlineCompanie>
    {
        AirlineCompanie GetAirlineCompaniesByUsername(string name);
        IList<AirlineCompanie> GetAllAirlinesCompanyByCountry(int countryid);
    }
}
