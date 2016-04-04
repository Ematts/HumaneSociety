using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class System
    {
        List<Dogs> dogList = new List<Dogs>();
        List<Cats> catList = new List<Cats>();
        List<Animal> animalList = new List<Animal>();
        
       
        

        public void menu()
        {
            Console.WriteLine("Press 1 if you would like to enter a new animal");
            int menuChoice = int.Parse(Console.ReadLine());
            if (menuChoice == 1)
            {
                addAnimal();
            }

        }

        public void addAnimal()
        {
            Console.WriteLine("Would you like to add a cat or dog?");
            string species = Console.ReadLine().ToLower();
            if (species == "dog")
            {
                addDog();
            }
            else if (species == "cat")
            {
                addCat();
            }

            else
            {
                Console.WriteLine("We take only cats or dogs.");
                addAnimal();
            }
        }

        public void addDog()
        {
            
            Console.WriteLine("Enter dog's name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter dog's breed");
            string breed = Console.ReadLine();
            Console.WriteLine("Enter dog's weight");
            double size = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter dog's age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter adoption price");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Has the dog been vaccinated: Yes or No?");
            string shots = Console.ReadLine().ToLower();
            bool shotStatus;

            if (shots == "yes")
            {

                shotStatus = true;
            }

            else

            {
                shotStatus = false;
            }

            Dogs dog = new Dogs(name, breed, size, age, price, shotStatus);
            dog.assignWeeklyDogFoodPounds();
            dog.assignCageNumber();
            dogList.Add(dog);
            animalList.Add(dog);
            Console.WriteLine("press 1 to return to menu, press 2 to exit program");
            int menuReturn = int.Parse(Console.ReadLine());

            if (menuReturn == 1)

            {
                menu();
            }
        }

        public void addCat()
        {

        }
        

    }
}

    
    

    

