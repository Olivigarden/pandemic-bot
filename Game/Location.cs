using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandemicBot.Game
{
    class Location
    {
        public string Name { get; private set; }
        public List<Location> AdjacentLocations { get; set; }

        public Location(string locName)
        {
            Name = locName;
            AdjacentLocations = new List<Location>();
        }
    }
}
