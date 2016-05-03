using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Interfaces
{
    interface IAnimal
    {
        void eat();
        void eat(string food);
        void sleep();
        void move();
        void reproduce();
    }
}
