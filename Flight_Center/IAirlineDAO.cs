using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Center
{
    interface IAirlineDAO:IBasicDB<AirlineCompanies>
    {
        AirlineCompanies GetAirlineCompaniesByUsername(string name);
        IList<AirlineCompanies> GetAllAirlinesCompanyByCountry(int countryid);
    }
}
