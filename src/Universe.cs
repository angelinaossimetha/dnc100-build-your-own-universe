/* 
    Will be a "container" object that holds one or more Galaxies in our world. 
*/ 
using System;
using System.Collections.Generic;
using System.Text;

namespace dnc100_build_your_own_universe
{
    public class Universe
    {
        private List<Galaxy> galaxies; 

        public Universe()
        {
            this.galaxies = new LinkedList<Galaxy>();
        }

        public void AddGalaxy(Galaxy galaxy)
        {
           this.galaxies.Add(galaxy);
        }
    }
}
