using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Model.Animals.Habitats
{
    public class Habitat
    {
        public int IdHabitat { get; set; }
        public string Name { get; set; }
        public int IdHabitatType { get; set; }
        public int IdEmployee { get; set; }

        public bool hasWalls { get; set; }
        public bool outside { get; set; }
        public string climateType { get; set; }
        public bool isAquatic { get; set; }
        public double baseTemperature { get; set; }
        public double width { get; set; }
        public double depth { get; set; }
        public double height { get; set; }
        public int windowCount { get; set; }

        public List<Animal> inhabitants { get; set; }
        // public List<Decorations> decorations { get; set; }
    }
}
