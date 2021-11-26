using System;
using System.Collections.Generic;
using System.Text;

namespace dnc100_build_your_own_universe
{
    public class Galaxy
    {
        private string name; 
        private List<SolarSystem> solarSystems; 

        public Galaxy(string name, List<SolarSystem> solarSystems)
        {
            this.name = name; 
            this.solarSystems = solarSystems;
        }

        public Galaxy() { 
            this.name = ""; 
            this.solarSystems = new LinkedList<>(); 
        }

        public void AddSolarSystem(SolarSystem solarSystem)
        {
           this.solarSystems.Add(solarSystem);
        }
    }
}
