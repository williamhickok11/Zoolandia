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
        private Genus _genus;

        public Genus genus
        {
            get
            {
                return _genus;
            }
            set
            {
                _genus = value;
            }
        }

        private string _speciesName;

        public string speciesName
        {
            get
            {
                return _speciesName;
            }
            set
            {
                _speciesName = value;
            }
        }

        private string _food = "";
        public virtual void eat(string food)
        {
            _food = food;
            Console.WriteLine("Currently eating {0}", food);
        }
    }




/*
// Species of Bears

class brownBear : Ursidae
{
    private bool _washesFood = true;
    // Overloaded constructor
    public brownBear(bool washes)
    {
        _washesFood = washes;
    }
    public brownBear(bool washes, string food)
    {
        _washesFood = washes;
        if (_washesFood == false)
        {
            Console.WriteLine("This bear is gross because he doesn't wash his {0}", food);
        }
    }
}

class polarBear : Ursidae
{
    private bool _washesFood = true;
    // Overloaded constructor
    public polarBear(bool washes)
    {
        _washesFood = washes;
    }
}
class grizzlyBear : Ursidae
{
    private bool _washesFood = true;
    // Overloaded constructor
    public grizzlyBear(bool washes)
    {
        _washesFood = washes;
    }
}
class caveBear : Ursidae
{
    private bool _washesFood = true;
    // Overloaded constructor
    public caveBear(bool washes)
    {
        _washesFood = washes;
    }
}

// Species of Raptors
class eagle : Falco
{
    private bool _washesFood = true;
    // Overloaded constructor
    public eagle(bool washes)
    {
        _washesFood = washes;
    }
    public eagle(bool washes, double wingspan)
    {
        wing_span = wingspan;
        if (wingspan > 5)
        {
            if (washes == true)
            {
                Console.WriteLine("That is a big bird that needs to wash it's wings");
            }
            else
            {
                Console.WriteLine("That is a big bird that does not wash it's wings");
            }
        }
        else
        {
            Console.WriteLine("This is a small bird");
        }
    }
}
class buzzard : Falco
{
    private bool _washesFood = true;
    // Overloaded constructor
    public buzzard(bool washes)
    {
        _washesFood = washes;
    }
    public buzzard(bool washes, int wingspan)
    {
        _washesFood = washes;
    }
}
class falcon : Falco
{
    private bool _washesFood = true;
    // Overloaded constructor
    public falcon(bool washes)
    {
        _washesFood = washes;
    }
    public falcon(bool washes, int wingspan)
    {
        _washesFood = washes;
    }
}

class vultures : Falco
{
    private bool _washesFood = true;
    // Overloaded constructor
    public vultures(bool washes)
    {
        _washesFood = washes;
    }
    public vultures(bool washes, int wingspan)
    {
        _washesFood = washes;
    }
}


// Species of Monkeys
class pig_tailed : Macaca
{
    private bool _washesFood = true;
    // Overloaded constructor
    public pig_tailed(bool washes, bool isMasked)
    {
        _washesFood = washes;
        _isMasked = isMasked;
    }
    public pig_tailed(bool washes)
    {
        _washesFood = washes;
    }
}
class moor : Macaca
{
    private bool _washesFood = true;
    // Overloaded constructor
    public moor(bool washes, bool isMasked)
    {
        _washesFood = washes;
        _isMasked = isMasked;
    }
    public moor(bool washes)
    {
        _washesFood = washes;
    }
}
class stump_tailed : Macaca
{
    private bool _washesFood = true;
    // Overloaded constructor
    public stump_tailed(bool washes, bool isMasked)
    {
        _washesFood = washes;
        _isMasked = isMasked;
    }
    public stump_tailed(bool washes)
    {
        _washesFood = washes;
    }
}
class Japanese : Macaca
{
    private bool _washesFood = true;
    // Overloaded constructor
    public Japanese(bool washes, bool isMasked)
    {
        _washesFood = washes;
        _isMasked = isMasked;
    }
    public Japanese(bool washes)
    {
        _washesFood = washes;
    }
}

*/

}