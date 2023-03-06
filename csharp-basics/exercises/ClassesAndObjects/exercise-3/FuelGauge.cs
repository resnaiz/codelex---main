using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_3
{
    public class FuelGauge
    {
        public int currentFuelAmount;

        public FuelGauge() 
        {
            this.currentFuelAmount = 0;
        }

        public int GetFuelAmount()
        {
            return currentFuelAmount;
        }

        public void RefuelLimit()
        {
            if(currentFuelAmount < 70)
            {
                currentFuelAmount++;
            }
        }

        public void FuelLow()
        {
            if(currentFuelAmount > 0)
            {
                currentFuelAmount--;
            }
        }
    }
}
