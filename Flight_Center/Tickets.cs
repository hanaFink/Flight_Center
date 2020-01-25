using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Center
{
    class Tickets : IPoco, IUser
    {
     

        public Int64 ID { get; set; }
        public Int64 FLIGHT_ID { get; set; }
        public Int64 CUSTOMER_ID { get; set; }

        public Tickets()
        {

        }

        public Tickets(long iD, long fLIGHT_ID, long cUSTOMER_ID)
        {
            ID = iD;
            FLIGHT_ID = fLIGHT_ID;
            CUSTOMER_ID = cUSTOMER_ID;
        }
        public static bool operator ==(Tickets first_member, Tickets second_member)
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
        public static bool operator !=(Tickets first_member, Tickets second_member)
        {
            return !(first_member == second_member);
        }
        public override bool Equals(object obj)
        {

            Tickets second_member = obj as Tickets;
            return this.ID == second_member.ID;
        }
        public override int GetHashCode()
        {
            int n;
            return n = (int)this.ID;
        }


    }
}
