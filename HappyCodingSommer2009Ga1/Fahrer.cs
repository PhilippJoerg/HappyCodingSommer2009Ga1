using System;
using System.Collections.Generic;
using System.Text;

namespace HappyCodingSommer2009Ga1
{
    class Fahrer
    {
        private int platzierung { get; set; }

        private Rennen rennen { get; set; }

        private Person person { get; set; }

        public Fahrer()
        {

        }

        public Fahrer(Person einePerson, int platzierung)
        {
            this.person = einePerson;
            this.platzierung = platzierung;
        }

        public void setzeTeilnahme(Rennen einRennen)
        {
            this.rennen = einRennen;
            
            einRennen.einschreibenFahrer(this);
        }
        public string getName()
        {
            string ret = string.Empty;

            ret = this.person.getName();

            return ret;
        }

        public int getPlatzierungen()
        {
            int ret = 0;

            ret = this.platzierung;

            return ret;
        }

        public Rennen getStartetBei()
        {
            Rennen ret = new Rennen();

            ret = this.rennen;

            return ret;
        }
    }
}
