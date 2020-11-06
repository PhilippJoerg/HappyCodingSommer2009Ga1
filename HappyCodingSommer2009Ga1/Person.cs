using System;
using System.Collections.Generic;
using System.Text;

namespace HappyCodingSommer2009Ga1
{
    class Person
    {
        private string name { get; set; }

        public Person()
        {

        }

        public Person(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            string ret = string.Empty;

            ret = this.name;

            return ret;
        }
    }
}
