using System;
using System.Collections.Generic;
using Sanctuary;

namespace Sanctuary
{
    public class Program
    {
        public static void Main()
        {

            Animal Georry = new Animal ("Georry", "giraffe", "2", "he/him", "very sweet, loves to eat leaves");
            Animal Petunia = new Animal ("Petunia", "panda", "7", "she/her", "controlling, bamboo hog");
            Animal Sal = new Animal ("Sal", "sloth", "4", "they/them", "slow and friendly");

            List<Animal> Animals = new List<Animal> () { Georry, Petunia, Sal};


            Console.WriteLine("Add a new animal? (y/n)");
            string addAnimal = Console.ReadLine();

            if (addAnimal == "y")
            {
                Console.WriteLine("What species?");
                string addSpecies = Console.ReadLine();

                Console.WriteLine("What age?");
                string addAge = Console.ReadLine();

                Console.WriteLine("What are their pronouns?");
                string addPronouns = Console.ReadLine();

                Console.WriteLine("What are they like?");
                string addDescription = Console.ReadLine();

                Console.WriteLine("What should we name them?");
                string addName = Console.ReadLine();

                 Animal constructorAnimal = new Animal (addName, addSpecies, addAge, addPronouns, addDescription);
                 Animals.Add(constructorAnimal);


                Console.WriteLine("Is this correct?");
                Console.WriteLine(constructorAnimal.GetName());

            }
            else
            {
                
                Console.WriteLine("Fine then.");
                
            }



        }
    }
}