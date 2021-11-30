using System;
using System.Collections.Generic;
using System.Text;

namespace dnc100_build_your_own_universe
{
    public class Galaxy
    {
        private string name;
        private LinkedList<SolarSystem> solarSystems;

        public Galaxy(string name, LinkedList<SolarSystem> solarSystems)
        {
            this.name = name;
            this.solarSystems = solarSystems;
        }

        public Galaxy()
        {
            this.name = "";
            this.solarSystems = new LinkedList<SolarSystem>();
        }

        public void AddSolarSystem(SolarSystem solarSystem)
        {
            this.solarSystems.AddLast(solarSystem);
        }
    }
}
