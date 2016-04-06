using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Animal


    {
        public string animalName;
        public int animalAge;
        public int cageNumber;
        public double adoptionPrice;
        public bool hasShots;


        public bool checkHasShots()
        {

            return hasShots;
                
        }

        public bool giveShot()
        {
            hasShots = true;
            return hasShots;
        }

        public int retieveCageNumber()
        {
            return cageNumber;
        }

        public string GetAnimalName()
        {
           
            return animalName;
        }
        public int getAnimalAge()
        {
            
            return animalAge;
        }

        public double getAdoptionPrice()
        {
            
            return adoptionPrice;
        }
    }
}



    

