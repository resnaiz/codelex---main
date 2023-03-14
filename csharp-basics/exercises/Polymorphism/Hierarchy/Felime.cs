using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    abstract class Felime : Mammal
    {
        public Felime(string animalType, string animalName, double animalWeight, int foodEaten, string livingRegion) : base(animalType, animalName, animalWeight, foodEaten, livingRegion)
        {
        }
    }
}
