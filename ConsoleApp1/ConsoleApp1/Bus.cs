using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bus:Car
    {
        public int PassengerCount;

        public Bus(string brand ,string model,string color,int maxspeed,int passengercount):base(brand,model,color,maxspeed)
        {
            PassengerCount = passengercount;
        }

        public override string Info()
        {
            return base.Info() + $" PassengerCount: {PassengerCount}";
        }
    }
}
