using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    internal class BookingClass
    {
        class temp:Booking
        {

        }
        private string Source;
        private string Destination;
        private string Passport;
        private string Kind_trip;
        private string PromoCode;
        private string Class_type ;
        private int Number_Of_Chairs;
        private string Time_Of_Departing;
        private string Time_Of_Returing;
        public BookingClass()
        {
             Source=null;
             Destination =null;
             Passport =null;
             Kind_trip = null;
             PromoCode = null;
             Class_type = null;
             Number_Of_Chairs=1;
             Time_Of_Departing =null;
             Time_Of_Returing = null;
        }
        public BookingClass(string S,string D,string P,string K,string PR,string CL,int Num,string TOD,string TOR)
        {
            Source = S;
            Destination = D;
            Passport = P;
            Kind_trip = K;
            PromoCode = PR;
            Class_type = CL;
            if (Num>0)
            {
                Number_Of_Chairs = Num;

            }
            
            Time_Of_Departing =TOD;
            Time_Of_Returing = TOR;
        }
        public void place(String S,String D,string Cl)
        {
            Source = S;
            Destination = D;
            Class_type = Cl;
        }
        
        public void flightInfo(string time1,string time2,string pass)
        {

            Time_Of_Departing = time1;
            Time_Of_Returing = time2;
            Passport = pass;
        }
        public void InfoTrip(string k,string prom,int n)
        {
            Kind_trip = k;
            PromoCode = prom;
            Number_Of_Chairs = n;
        }
        public void SET_Source(string temp)
        {
            Source = temp;
        }
        public string Get_Source()
        {
            return Source;
        }
        public void SET_Destination(string temp)
        {
            Destination = temp;
        }
        public string Get_Destination()
        {
            return Destination;
        }
        public void SET_Passport(string temp)
        {
            Passport = temp;
        }
        public string Get_Passport()
        {
            return Passport;
        }
        public void SET_Kind_trip(string temp)
        {
            Kind_trip = temp;
        }
        public string Get_Kind_trip()
        {
            return Kind_trip;
        }
        public void SET_PromoCode(string temp)
        {
            PromoCode = temp;
        }
        public string Get_PromoCode()
        {
            return PromoCode;
        }
        public void SET_Class_type(string temp) {
            Class_type = temp;
        }
        public string Get_Class_type()
        {
            return Class_type;
        }
        public void SET_Number_Of_Chairs(int temp)
        {
            Number_Of_Chairs = temp;
        }
        public int Get_Number_Of_Chairs()
        {
            return Number_Of_Chairs;
        }
        public void SET_Time_Of_Departing(string temp)
        {
            Time_Of_Departing = temp;
        }
        public string Get_Time_Of_Departing()
        {
            return Time_Of_Departing;
        }
        public void SET_Time_Of_Returing(string temp)
        {
            Time_Of_Returing = temp;
        }

        public string Get_Time_Of_Returing()
        {
            return Time_Of_Returing;
        }


    }
}
