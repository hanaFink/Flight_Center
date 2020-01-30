using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Center
{
    class Countries : IPoco, IUser
    {

       

        public Int64 ID { get; set; }
        public string COUNTRY_NAME { get; set; }

        public Countries()
        {

        }

        public Countries(long iD, string cOUNTRY_NAME):base()
        {
            ID = iD;
            COUNTRY_NAME = cOUNTRY_NAME;
        }
        public static bool operator ==(Countries first_member, Countries second_member)
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
        public static bool operator !=(Countries first_member, Countries second_member)
        {
            return !(first_member == second_member);
        }
        public override bool Equals(object obj)
        {

            Countries second_member = obj as Countries;
            return this.ID == second_member.ID;
        }
        public override int GetHashCode()
        {
            int n;
            return n = (int)this.ID;
        }
    }
}
