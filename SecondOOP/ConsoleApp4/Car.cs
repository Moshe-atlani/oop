using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Car : Vehicles
    {

        private string owner;//הרכב בעל

        public Car(string owner)
        {
            this.owner = owner;
        }

        public string GetOwner() { return owner; }
        public void SetOwner(string owner)
        {
            this.owner = owner;
        }
        public string ToStringCar(string s)//c t override ...
        {
            s = "Car made by " + GetManuf() + " Engine:";
            s += ToStringVehicles();
            s += " and is owned by " + owner;
            return s;

        }



    }
}
