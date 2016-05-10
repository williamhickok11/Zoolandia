using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Models
{
    public class Species
    {
        public int IdSpecies { get; set; }
        public string ScientificName { get; set; }
        public string CommonName { get; set; }
        public string WikiLink { get; set; }
    }
}
