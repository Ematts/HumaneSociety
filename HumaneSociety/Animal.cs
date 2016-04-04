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
            Console.WriteLine("Enter Animal's Name:");
            animalName = Console.ReadLine();
            return animalName;
        }
        public int GetAnimalAge()
        {
            Console.WriteLine("Enter age of Animal:");
            animalAge = int.Parse(Console.ReadLine());
            return animalAge;
        }

        public double SetAdoptionPrice()
        {
            Console.WriteLine("Enter Adoption Price:");
            adoptionPrice = double.Parse(Console.ReadLine());
            return adoptionPrice;
        }
    }
}



    

