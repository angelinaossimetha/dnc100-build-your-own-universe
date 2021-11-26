using System;
using System.Collections.Generic;
using System.Text;

namespace dnc100_build_your_own_universe
{
    public class SolarSystem
    {
        private string name; 
        private Star star;
        private List<Planet> planets; 

        public SolarSystem(string name, Star star, List<Planet> planets)
        {
            this.name = name; 
            this.star = star; 
            this.planets = planets;
        }

        public SolarSystem()
        {
            this.name = ""; 
            this.star = new Star(); 
            this.planets = new LinkedList<>();
        }

        public void AddStar(Star star) { 
            this.star = star;
        }

        public void AddPlanet(Planet planet) { 
            this.planets.Add(planet);
        }
    }
}
