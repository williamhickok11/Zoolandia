using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Taxonomy.Species;

namespace Zoolandia.Interfaces
{
    interface IAnimal
    {
        int IdAnimal { get; set; }
        string Name { get; set; }
        Species IdSpecies { get; set; }
        Habitat IdHabitat { get; set; }

        void eat();
        void eat(string food);
        void sleep();
        void move();
        void reproduce();
    }
}
