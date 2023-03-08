using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_3
{
    internal class Odometer
    {
        public int currentMileage;
        public FuelGauge fuelGauge;

        public Odometer()
        {
            currentMileage = 0;
            fuelGauge = new FuelGauge();
        }

        public int GetMileage()
        {
            return currentMileage;
        }

        public void IncreaseMileage()
        {
            if(currentMileage < 999999)
            {
                currentMileage++;
                
                if(currentMileage % 10 == 0)
                {
                    fuelGauge.FuelLow();
                }
            }
            else
            {
                currentMileage = 0;
            }
        }
    }
}
