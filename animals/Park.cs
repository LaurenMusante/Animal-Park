using System;
using System.Collections.Generic;
using Sanctuary;


namespace Sanctuary 
{
    class Animal 
    {
        private string _name;
        private string _species;
        private string _age;
        private string _pronouns;
        private string _description;

        public Animal(string name, string species, string age, string pronouns, string description) 
        {
            _name = name;
            _species = species;
            _age = age;
            _pronouns = pronouns;
            _description = description;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetSpecies()
        {
            return _species;
        }
        public string GetAge()
        {
            return _age;
        }
        public string GetPronouns()
        {
            return _pronouns;
        }

        public string GetDescription()
        {
            return _description;
        }



    }
}