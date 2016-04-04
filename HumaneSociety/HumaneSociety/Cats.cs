using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Cats : Animal
    {
        ///Cat variables

        string catBreed;
        double catSize;
        double weeklyCatFoodPounds;
        
        public Cats(string AnimalName, string CatBreed, double CatSize, int AnimalAge, double AdoptionPrice, bool HasShots)
        {

            animalName = AnimalName;
            catBreed = CatBreed;
            catSize = CatSize;
            animalAge = AnimalAge;
            adoptionPrice = AdoptionPrice;
            hasShots = HasShots;
       
        }

        public double assignWeeklyCatFoodPounds()
        {
            if (catSize <= 5)
            {
                weeklyCatFoodPounds = 1;
            }

            else if ((catSize > 5) && (catSize < 15))
            {
                weeklyCatFoodPounds = 2;
            }

            else
            {
                weeklyCatFoodPounds = 3;
            }

            return weeklyCatFoodPounds;
        }

        public int assignCageNumber()
        {
            if (catSize <= 5)
            {
                cageNumber = 4;
            }

            else if ((catSize > 5) && (catSize < 15))
            {
                cageNumber = 5;
            }

            else
            {
                cageNumber = 6;
            }

            return cageNumber;
        }

    }
}

