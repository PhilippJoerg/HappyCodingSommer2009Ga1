using System;
using System.Collections.Generic;
using System.Text;

namespace HappyCodingSommer2009Ga1
{
    class Datenbasis
    {
        private List<Person> personenListe { get; set; }
        private List<Rennen> rennenListe { get; set; }

        public Datenbasis()
        {
            personenListe = new List<Person>();
            rennenListe = new List<Rennen>();
        }

        public void addPerson(Person person)
        {
            personenListe.Add(person);
        }
        
        public void addRennen(Rennen rennen)
        {
            rennenListe.Add(rennen);
        }

        public List<Person> getPersonenListe()
        {
            return personenListe;
        }

        public List<Rennen> getRennListe()
        {
            return rennenListe;
        }
    }
}
