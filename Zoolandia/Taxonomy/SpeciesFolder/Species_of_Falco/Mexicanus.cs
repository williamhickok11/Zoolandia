using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Taxonomy.Species.Species_of_Falco
{
    class Mexicanus : Species
    {
        public Mexicanus()
        {
            this.url = "https://en.wikipedia.org/wiki/Chinese_mantis";
            // this.genus = new Tenodera("Asia");
            this.scientificName = "Tenodera sinensis";
            this.commonName = "Chinese Mantis";
        }
    }
}
