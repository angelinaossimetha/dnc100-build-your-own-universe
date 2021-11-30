/* 
    will be a "container" object that holds one or more galaxies in our world. 
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace dnc100_build_your_own_universe
{
    public class Universe
    {
        private LinkedList<Galaxy> galaxies;

        public Universe()
        {
            this.galaxies = new LinkedList<Galaxy>();
        }

        public void AddGalaxy(Galaxy galaxy)
        {
            this.galaxies.AddLast(galaxy);
        }
    }
}
