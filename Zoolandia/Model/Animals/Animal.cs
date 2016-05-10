using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Interfaces;

namespace Zoolandia.Model
{
    public class Animal //: IAnimal
    {
        public int IdAnimal { get; set; }
        public string Name { get; set; }
        public int IdHabitat { get; set; }
        public int IdSpecies { get; set; }


        public Habitat Habitat { get; set; }
        public Species Species { get; set; }
        public void eat() {}
        public void eat(string food) {}
        public void move() {}
        public void reproduce() {}
        public void sleep() {}
    }
}
