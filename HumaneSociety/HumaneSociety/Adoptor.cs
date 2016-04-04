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
        double wallet;
        List<Adoptor> adoptionList = new List<Adoptor>();

        public Adoptor(string FirstName, string LastName, double Wallet)
        {
            firstName = FirstName;
            lastName = LastName;
            wallet = Wallet;
        }

    }

   
}

///function for adding adopters to list
///function for adopting that includes removing money from wallet, animal from system, and adding animal to adoptionlist
