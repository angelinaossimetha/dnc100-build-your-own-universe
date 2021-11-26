using System;
using System.Collections.Generic;
using System.Text;

namespace dnc100_build_your_own_universe
{
    public class LifeForm
    {
        private string firstName; 
        private string lastName; 

        public LifeForm(string firstName, string lastName)
        {
            this.firstName = firstName; 
            this.lastName = lastName;
        }
        
        public LifeForm() { 
            this.firstName = "";
            this.lastName = "";
        }
    }
}
