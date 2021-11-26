using System;
using System.Collections.Generic;
using System.Text;

namespace dnc100_build_your_own_universe
{
    public class Planet
    {
        private string name; 
        private List<LifeForm> lifeForms; 

        public Planet(string name, List<LifeForm> lifeForms)
        {
            this.name = name;
            this.lifeForms = lifeForms;
        }

        public Planet() { 
            this.name = ""; 
            this.lifeForms = new List<LifeForm>();
        }

        public void AddLifeForm(LifeForm lifeForm) { 
            this.lifeForms.Add(lifeForm);
        }
    }

    
}
