﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Center
{
    public class AirlineCompanie: IPoco, IUser
    {
      

        public Int64 ID { get; set; }
        public string AIRLINE_NAME { get; set; }
        public string USER_NAME { get; set; }
        public string PASSWORD { get; set; }
        public int COUNTRY_CODE { get; set; }
        public AirlineCompanie()
        {

        }


        public AirlineCompanie(long iD, string aIRLINE_NAME, string uSER_NAME, string pASSWORD, int cOUNTRY_CODE)
        {
            ID = iD;
            AIRLINE_NAME = aIRLINE_NAME;
            USER_NAME = uSER_NAME;
            PASSWORD = pASSWORD;
            COUNTRY_CODE = cOUNTRY_CODE;
        }

        public static bool operator == (AirlineCompanie first_member, AirlineCompanie second_member)
        {
            if ((ReferenceEquals(first_member,null)) && ReferenceEquals(second_member,null))
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
        public static bool operator != (AirlineCompanie first_member, AirlineCompanie second_member)
        {
            return !(first_member == second_member);
        }
        public override bool Equals(object obj)
        {

            AirlineCompanie second_member = obj as AirlineCompanie;
            return this.ID == second_member.ID;
        }
        public override int GetHashCode()
        {
            int n;
            return n =(int)this.ID;
        }

        public override string ToString()
        {
            return $"ID = {ID} AIRLINE_NAME = {AIRLINE_NAME} USER_NAME = {USER_NAME} PASSWORD = {PASSWORD}  COUNTRY_CODE = { COUNTRY_CODE}";
         
        }
    }
}
