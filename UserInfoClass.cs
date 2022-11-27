using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    internal class UserInfoClass
    {
        private string FristName;
        private string LastName;
        private string nationality;
        private string passport;
        private int PersonalID;
        public UserInfoClass()
        {
           FristName = " ";
            LastName = " ";
            nationality = " ";
            PersonalID = 0 ;
            passport = " ";
        }
        public UserInfoClass(string fn,string ln,string n,string pass,int id)
        {
           FristName=fn;
            LastName=ln;
            nationality=n;
            PersonalID=id;
            passport=pass;
        }
        public void SET_FirstName(string temp)
        {
           FristName = temp;
        }
        public string GET_FirstName()
        {
            return FristName;
        }
        public void SET_LastName(string temp)
        {
            LastName = temp;
        }
        public string GET_LastName()
        {
            return LastName;
        }
        public void SET_nationality(string temp)
        {
            nationality = temp;
        }
        public string GET_nationality()
        {
            return nationality;
        }
        public void SET_PersonalID(int temp)
        {
            PersonalID = temp;
        }
        public int GET_PersonalID()
        {
            return PersonalID;
        }
        public void SET_passport(string temp)
        {
            passport = temp;
        }
        public string GET_passport()
        {
            return passport;
        }
        public void Full_Name(string fname,string lname)
        {
            FristName=fname;
            LastName=lname;
        }
        public void User_Info(string Nationality,int ID,string pass)
        {
            nationality = Nationality;
            PersonalID = ID;
            passport=pass;
        }


    }
}
