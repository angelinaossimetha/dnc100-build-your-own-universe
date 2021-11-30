using System;
using System.Collections.Generic;
using System.Text;

namespace dnc100_build_your_own_universe
{
    public class LifeForm
    {
        private string firstname;
        private string lastname;

        public LifeForm(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public LifeForm()
        {
            this.firstname = "";
            this.lastname = "";
        }
    }
}
