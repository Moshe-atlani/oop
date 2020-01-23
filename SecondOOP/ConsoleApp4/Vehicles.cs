using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Vehicles
    {
        private int engineVol; //moteur du volume
        private int wheels; // nombre de roue 
        private string manuf;// createur / constructeur

        public Vehicles(int vol, string man)
        {
            this.engineVol = vol;
            this.wheels = 4;
            this.manuf = man;
        }

        public int GetWheelCount() { return wheels; }
        public int GetEngineVol() { return engineVol; }
        public string GetManuf() { return manuf; }

        public string ToStringVehicles()//c t un override mais jsp pk
        {
            string s = "Car made by " + manuf + " Engine:";//CAR
            s += string.Format(" {0} cc ", engineVol);
            s += string.Format(" with {0} wheels", wheels);
            
            return s;
        }

    }
}
