using System;
using System.Collections.Generic;
using System.Text;

namespace HappyCodingSommer2009Ga1
{
    class Rennen
    {
        private string ort { get; set; }
        private int anzahlStarter { get; set; }

        List<Fahrer> fahrers { get; set; }

        public Rennen()
        {
            fahrers = new List<Fahrer>();
        }

        public Rennen(string ort, int anzahlStarter)
        {
            fahrers = new List<Fahrer>();

            this.ort = ort;
            this.anzahlStarter = anzahlStarter;
        }

        public string getOrt()
        {
            string ret = string.Empty;

            ret = this.ort;

            return ret;
        }

        public void einschreibenFahrer(Fahrer einFahrer)
        {
            fahrers.Add(einFahrer);
        }

        public int getAzahlStarter()
        {
            int ret = 0;

            ret = anzahlStarter;

            return ret;
        }

        public List<Fahrer> getTeilnehmer()
        {
            List<Fahrer> ret = new List<Fahrer>();

            ret = this.fahrers;

            return ret;
        }
    }
}
