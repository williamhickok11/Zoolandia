using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia
{
    class Falco : Species
    {
        private string _continent;

        public string continent
        {
            get
            {
                return _continent;
            }
            set
            {
                if (value != "")
                {
                    _continent = value;
                }
            }
        }

        private void init()
        {
            this.url = "https://en.wikipedia.org/wiki/Tenodera";
            this.trait = "apical spine";
            this.commonName = "Mantis";
            this.scientificName = "Tenodera";
        }

        public Tenodera()
        {
            this.init();
        }

        public Tenodera(string continent)
        {
            this.init();
            this.continent = continent;
        }
    }
}
