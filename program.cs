using System;
using System.Collections.Generic;
using Sanctuary;

namespace Sanctuary {
    public class Program {
        public static void Main () {
            Animal Georry = new Animal ("Georry", "giraffe", "2", "he/him", "very sweet, loves to eat leaves");
            Animal Petunia = new Animal ("Petunia", "panda", "7", "she/her", "controlling, bamboo hog");
            Animal Sal = new Animal ("Sal", "sloth", "4", "they/them", "slow and friendly");

            List<Animal> animals = new List<Animal> (0);
            AnimalOnboarding (animals);
        }

        public static void AnimalOnboarding (List<Animal> animals) {
            Console.WriteLine ("Add a new animal? (y/n)");
            string addAnimal = Console.ReadLine ();
            if (addAnimal == "y" || addAnimal == "Y") {
                Console.WriteLine ("What species?");
                string addSpecies = Console.ReadLine ();

                Console.WriteLine ("What age?");
                string addAge = Console.ReadLine ();

                Console.WriteLine ("What are their pronouns?");
                string addPronouns = Console.ReadLine ();

                Console.WriteLine ("What are they like?");
                string addDescription = Console.ReadLine ();

                Console.WriteLine ("What should we name them?");
                string addName = Console.ReadLine ();

                Animal constructorAnimal = new Animal (addName, addSpecies, addAge, addPronouns, addDescription);

                animals.Add (constructorAnimal);

                Console.WriteLine ("Here's the updated list of animals:");

                foreach (Animal creature in animals) {
                    Console.WriteLine (creature.GetName ());
                }
                AnimalOnboarding (animals);

            } else {

                Console.WriteLine ("Fine then.");

            }

        }

    }
}