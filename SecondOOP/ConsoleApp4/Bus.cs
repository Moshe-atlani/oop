using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Bus : Vehicles
    {

        private int passengers;//נוסעים' מס

        public Bus(int vol, string man, int pass)//change Car to Bus
        {
            this.passengers = pass;
        }
        public int GetPass() { return passengers; }

        public string ToStringBus()
        {
            string s = "Bus made by " + GetManuf() + " Engine:";
            s += ToStringVehicles();
            s += string.Format(" and can take {0} passengers"
            , passengers);
            return s;
        }
    }
}
