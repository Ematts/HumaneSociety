using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Adoptor
    {
        string firstName;
        string lastName;
        public int idNumber;
        public List<Animal> adoptionList = new List<Animal>();

        public Adoptor(string FirstName, string LastName, int IDNumber)
        {
            firstName = FirstName;
            lastName = LastName;
            idNumber = IDNumber;
        }

    }

   
}

///function for adding adopters to list
///function for adopting that includes removing money from wallet, animal from system, and adding animal to adoptionlist
