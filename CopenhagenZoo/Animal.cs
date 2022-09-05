using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopenhagenZoo
{
    internal class Animal
    {
        //Instance variables
        private string race;
        private bool gender;

        //Encapsulations
        public string Race { get { return race; } }
        public bool Gender { get { return gender; } }

        //Constructor
        public Animal(string race, bool gender, List<Animal> animals)
        {
            this.race = race;
            this.gender = gender;
            animals.Add(this);
        }        
    }
}