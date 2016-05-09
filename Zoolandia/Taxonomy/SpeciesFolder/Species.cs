using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Taxonomy;

namespace Zoolandia.Taxonomy.Species
{
    class Species : Taxonomy
    {
        public int IdSpecies { get; set; }
        public string ScientifName { get; set; }
        public string CommonName { get; set; }
        public string WikiLink { get; set; }	


        private Genus _genus;
        public Genus genus
        {
            get { return _genus; }
            set { _genus = value; }
        }

        private string _speciesName;

        public string speciesName
        {
            get { return _speciesName; }
            set { _speciesName = value; }
        }

        private string _food = "";
        public virtual void eat(string food)
        {
            _food = food;
            Console.WriteLine("Currently eating {0}", food);
        }
    }
}

    