using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Interfaces;
using Zoolandia.Taxonomy.Species;

namespace Zoolandia.Animals
{
    class Animal : IAnimal
    {
        public int IdAnimal { get; set; }
        public string Name { get; set; }
        public Habitat IdHabitat { get; set; }
        public Species IdSpecies { get; set; }

        public void eat() {}
        public void eat(string food) {}
        public void move() {}
        public void reproduce() {}
        public void sleep() {}
    }
}
