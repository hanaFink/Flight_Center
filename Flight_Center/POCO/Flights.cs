using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Center
{
    public class Flight : IPoco, IUser
    {
     
        public Int64 ID { get; set; }
        public Int64 AIRLINECOMPANY_ID { get; set; }
        public Int64 ORIGIN_COUNTRY_CODE { get; set; }
        public Int64 DESTINATION_COUNTRY_CODE { get; set; }
        public DateTime DEPARTURE_TIME { get; set; }
        public DateTime ACTUAL_DEPARTURE_TIME { get; set; }
        public DateTime LANDING_TIME { get; set; }
        public DateTime ACTUAL_LANDING_TIME { get; set; }
        public int REMAINING_TICKETS { get; set; }

        public Flight()
        {

        }
        public Flight(long iD, long aIRLINECOMPANY_ID, long oRIGIN_COUNTRY_CODE, long dESTINATION_COUNTRY_CODE, DateTime dEPARTURE_TIME, DateTime aCTUAL_DEPARTURE_TIME, DateTime lANDING_TIME, DateTime aCTUAL_LANDING_TIME, int rEMAINING_TICKETS)
        {
            ID = iD;
            AIRLINECOMPANY_ID = aIRLINECOMPANY_ID;
            ORIGIN_COUNTRY_CODE = oRIGIN_COUNTRY_CODE;
            DESTINATION_COUNTRY_CODE = dESTINATION_COUNTRY_CODE;
            DEPARTURE_TIME = dEPARTURE_TIME;
            ACTUAL_DEPARTURE_TIME = aCTUAL_DEPARTURE_TIME;
            LANDING_TIME = lANDING_TIME;
            ACTUAL_LANDING_TIME = aCTUAL_LANDING_TIME;
            REMAINING_TICKETS = rEMAINING_TICKETS;
        }

        public static bool operator ==(Flight first_member, Flight second_member)
        {
            if ((ReferenceEquals(first_member, null)) && ReferenceEquals(second_member, null))
            {
                return true;
            }
            if ((ReferenceEquals(first_member, null)) || ReferenceEquals(second_member, null))
            {
                return false;
            }
            if (first_member.ID == second_member.ID)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Flight first_member, Flight second_member)
        {
            return !(first_member == second_member);
        }
        public override bool Equals(object obj)
        {

            Flight second_member = obj as Flight;
            return this.ID == second_member.ID;
        }
        public override int GetHashCode()
        {
            int n;
            return n = (int)this.ID;
        }

        public override string ToString()
        {
            return $" {ID} = iD { AIRLINECOMPANY_ID} = aIRLINECOMPANY_ID { ORIGIN_COUNTRY_CODE} = oRIGIN_COUNTRY_CODE { DESTINATION_COUNTRY_CODE }= dESTINATION_COUNTRY_CODE { DEPARTURE_TIME} = dEPARTURE_TIME { ACTUAL_DEPARTURE_TIME} = aCTUAL_DEPARTURE_TIME;{ LANDING_TIME} = lANDING_TIME;{ ACTUAL_LANDING_TIME} = aCTUAL_LANDING_TIME; { REMAINING_TICKETS} = rEMAINING_TICKETS; ";
        }
    }
}
