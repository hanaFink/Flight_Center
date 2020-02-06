using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Center
{
    public class Customers : IPoco, IUser
    {
       

        public Int64 ID { get; set; }
        public string FIRST_NAME { get; set; }

        public string LAST_NAME { get; set; }
        public string USER_NAME { get; set; }
        public string PASSWORD { get; set; }
        public string ADDRESS { get; set; }
        public string PHONE_NO { get; set; }
        public string CREDIT_CARD_NUMBER { get; set; }

        public Customers()
        { 
        }
        public Customers(long iD, string fIRST_NAME, string lAST_NAME, string uSER_NAME, string pASSWORD, string aDDRESS, string pHONE_NO, string cREDIT_CARD_NUMBER)
        {
            ID = iD;
            FIRST_NAME = fIRST_NAME;
            LAST_NAME = lAST_NAME;
            USER_NAME = uSER_NAME;
            PASSWORD = pASSWORD;
            ADDRESS = aDDRESS;
            PHONE_NO = pHONE_NO;
            CREDIT_CARD_NUMBER = cREDIT_CARD_NUMBER;
        }

        public static bool operator ==(Customers first_member, Customers second_member)
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
        public static bool operator !=(Customers first_member, Customers second_member)
        {
            return !(first_member == second_member);
        }
        public override bool Equals(object obj)
        {

            Customers second_member = obj as Customers;
            return this.ID == second_member.ID;
        }
        public override int GetHashCode()
        {
            int n;
            return n = (int)this.ID;
        }


    }
}
