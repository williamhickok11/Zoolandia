using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia
{
    class Animal // : IAnimal
    {
        string name { get; set; }
        string food { get; set; }
        private Species _species;

        public Species species
        {
            get
            {
                return _species;
            }
            set
            {
                _species = value;
            }
        }

        /*
          Public property that is accessible by other classes but
          can only be read, not manipulated.
         */
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        /*
          Public property that is accessible by other classes that
          can be read and set, but with some conditional logic that
          checks the value before the private variable is set.
          Animal adam = new Animal();
          adam.food = "Banana";   <-- will compile
          adam.food = "";         <-- will not compile
         */
        public string food
        {
            get
            {
                return _food;
            }
            set
            {
                if (value != "")
                {
                    _food = value;
                }
            }
        }
        /*
          Your first method on a class.
         */

    }
}
