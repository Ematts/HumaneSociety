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
        List<Adoptor> adoptorList = new List<Adoptor>();
        Bank bank = new Bank();


        public void menu()
        {
           Console.WriteLine("Press 1 if you would like to enter a new animal, press 2 if you would like to add an adoptor profile, press 3 if you would like to perform an adoption");
           int menuChoice = int.Parse(Console.ReadLine());
           if (menuChoice == 1)
                {

                addAnimal();

                }

            else if (menuChoice == 2)

                {

                addAdoptor();

                }

            else if (menuChoice == 3)

                {

                performAdoption();

                }

           else

                {

                Console.WriteLine("yo");

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
            Console.WriteLine("Enter cats's name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter cats's breed");
            string breed = Console.ReadLine();
            Console.WriteLine("Enter cats's weight");
            double size = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter cats's age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter adoption price");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Has the cat been vaccinated: Yes or No?");
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

            Cats cat = new Cats(name, breed, size, age, price, shotStatus);
            cat.assignWeeklyCatFoodPounds();
            cat.assignCageNumber();
            catList.Add(cat);
            animalList.Add(cat);
            Console.WriteLine("press 1 to return to menu, press 2 to exit program");
            int menuReturn = int.Parse(Console.ReadLine());

            if (menuReturn == 1)

            {
                menu();
            }
        }

        public void addAdoptor()
        {

            Console.WriteLine("Enter adoptor's first name");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter adoptor's last name");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter adoptors's ID number");
            int idNumber = int.Parse(Console.ReadLine());

            Adoptor adoptor = new Adoptor(firstname, lastname, idNumber);
            adoptorList.Add(adoptor);
            Console.WriteLine("press 1 to return to menu, press 2 to exit program");
            int menuReturn = int.Parse(Console.ReadLine());

            if (menuReturn == 1)

            {
                menu();
            }

        }

        public void performAdoption()
        {
            Console.WriteLine("Enter adoptor's ID number");
            int id = int.Parse(Console.ReadLine());
            foreach (Adoptor adoptor in adoptorList)
            {
                if (id == adoptor.idNumber)
                {
                    Console.WriteLine("Enter name of animal");
                    string petName = Console.ReadLine(); 
                        foreach (Animal animal in animalList)
                        {
                            if (petName == animal.animalName)
                                {
                                    animalList.Remove(animal);
                                    bank.accountBalance += animal.adoptionPrice;
                                    adoptor.adoptionList.Add(animal);
                                    Console.WriteLine("Adoption complete. " + animal.animalName + " has been removed from the system. \n  Press 1 to return to menu, press 2 to exit program");
                                    int menuReturn = int.Parse(Console.ReadLine());
                            
                                        if (menuReturn == 1)

                                         {
                                             menu();
                                         }

                                }
                            else
                                {
                            Console.WriteLine("");
                                 
                              

                                }
                        }
                }

            }

            {

            }
        }
    
    }

}

    

    
    

    

