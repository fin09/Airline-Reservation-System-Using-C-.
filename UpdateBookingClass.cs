using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    internal class UpdateBookingClass : BookingClass
    {
        private int Cost;

        public UpdateBookingClass():base()
        {
            Cost = 0;
        }
        public UpdateBookingClass(int C, string S, string D, string P, string K, string PR, string CL, int Num, string TOD, string TOR) : base(S, D, P, K, PR, CL, Num, TOD, TOR)
        {
            Cost = C;
        }
        public void Set_Cost(int temp)
        {
            Cost = temp;
        }
        public int Get_Cost()
        {
            return Cost;
        }

    }
}
