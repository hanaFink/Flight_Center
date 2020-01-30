using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Center
{
    public class Ticket : IPoco, IUser
    {
        
        public int ID { get; set; }
        public int FLIGHT_ID { get; set; }
        public int CUSTOMER_ID { get; set; }

        public Ticket()
        {

        }

        public Ticket(int iD, int fLIGHT_ID, int cUSTOMER_ID)
        {
            ID = iD;
            FLIGHT_ID = fLIGHT_ID;
            CUSTOMER_ID = cUSTOMER_ID;
        }
        public static bool operator ==(Ticket first_member, Ticket second_member)
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
        public static bool operator !=(Ticket first_member, Ticket second_member)
        {
            return !(first_member == second_member);
        }
        public override bool Equals(object obj)
        {

            Ticket second_member = obj as Ticket;
            return this.ID == second_member.ID;
        }
        public override int GetHashCode()
        {
            int n;
            return n = (int)this.ID;
        }


    }
}
