using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_4
{
    internal class ParkingSystem
    {
        private int[] parkingSpaces;
        //public int Availability { get; private set; }

        public ParkingSystem(int big, int medium, int small)
        {
            parkingSpaces = new int[3];
            parkingSpaces[0] += big;
            parkingSpaces[1] += medium;
            parkingSpaces[2] += small;
            //Availability += big;
            //Availability += medium;
            //Availability += small;
        }

        public bool AddCar(int carType)
        {
            if (carType < 1 || carType > 3) return false;

            if (parkingSpaces[carType - 1] > 0)
            {
                parkingSpaces[carType - 1]--;
                //this.Availability--;
                return true;
            }
            return false;
        }
    }


}
