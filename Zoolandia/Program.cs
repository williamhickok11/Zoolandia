using System;
using System.Collections.Generic;
using Zoolandia.Species_Names.Falco;
using Zoolandia.Species_Names.Macaca;

namespace Zoolandia
{
    class Zoolandia
    {
        static void Main(string[] args)
        {
            Savanna savanna = new Savanna();
            Aquatic aquarium = new Aquatic();
            Habitat snakePit = new Habitat();
            Habitat aviary = new Habitat();

            savanna.inhabitants = new List<Animal>();

            Owl manny = new Owl();
            manny.name = "Manny";
            manny.species = new Falco();

            Owl danny = new Owl();
            manny.name = "Danny";
            manny.species = new Falco();

            crestedBlack wildBill = new crestedBlack();
            manny.name = "WildBill";
            // manny.species = new SPECIESNAMEHERE();

            savanna.inhabitants.Add(manny);
            savanna.inhabitants.Add(danny);

            foreach(Animal a in savanna.inhabitants)
            {
                Console.WriteLine(a.name);
            }

            // Animal firstAnimal = new Animal(args[0]);
            // firstAnimal.species = new TenoderaAngustipennis();

            // Console.WriteLine("{0} the {1}", firstAnimal.name, firstAnimal.species.commonName);
        }
    }
}