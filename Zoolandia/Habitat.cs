using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Animals;

namespace Zoolandia
{
    class Habitat
    {
        public bool hasWalls;
        public bool outside;
        public string climateType;
        public bool isAquatic;
        public double baseTemperature;
        public double width;
        public double depth;
        public double height;
        public int windowCount;

        public List<Animal> inhabitants;
        // public List<Decorations> decorations { get; set; }
    }
}
