﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Models
{
    public class Habitat
    {
        public int IdHabitat { get; set; }
        public string Name { get; set; }
        public int IdHabitatType { get; set; }
        public int IdEmployee { get; set; }
    }
}
