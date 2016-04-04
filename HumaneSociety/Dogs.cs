using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Dogs : Animal
    {

        string dogBreed;
        double dogSize;
        double weeklyDogFoodPounds;
        

        public Dogs(string AnimalName, string DogBreed, double DogSize, int AnimalAge, double AdoptionPrice, bool HasShots)
        {

            animalName = AnimalName;
            dogBreed = DogBreed;
            dogSize = DogSize;
            animalAge = AnimalAge;
            adoptionPrice = AdoptionPrice;
            hasShots = HasShots;
            

        }
        public double assignWeeklyDogFoodPounds ()
        {
            if (dogSize <= 20)
            {
                weeklyDogFoodPounds = 2;
            }

            else if ((dogSize > 20) && (dogSize < 60))
            {
                weeklyDogFoodPounds = 4;
            }

            else
            {
                weeklyDogFoodPounds = 6;
            }

            return weeklyDogFoodPounds;
        }

        public int assignCageNumber()
        {
            if (dogSize <= 20)
            {
                cageNumber = 1;
            }

            else if ((dogSize > 20) && (dogSize < 60))
            {
                cageNumber = 2;
            }

            else
            {
                cageNumber = 3;
            }

            return cageNumber;
        }

    }   
}
