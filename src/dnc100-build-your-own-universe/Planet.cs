using System;
using System.Collections.Generic;
using System.Text;

namespace dnc100_build_your_own_universe
{
    public class Planet
    {
        private string name;
        private LinkedList<LifeForm> lifeforms;

        public Planet(string name, LinkedList<LifeForm> lifeforms)
        {
            this.name = name;
            this.lifeforms = lifeforms;
        }

        public Planet()
        {
            this.name = "";
            this.lifeforms = new LinkedList<LifeForm>();
        }

        public void AddLifeForm(LifeForm lifeform)
        {
            this.lifeforms.AddLast(lifeform);
        }
    }


}
