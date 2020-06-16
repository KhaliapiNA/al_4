using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace al_4
{
    class Telo
    {
        int dlina;
        string name;

        public Telo(int d, string n)
        {
            dlina = d;
            name = n;
        }

        public int DLINA
        {
            get { return dlina; }
            set { dlina= value;}
        }
        public string NAME
        {
            get { return name; }
            set { name = value; }
        }
    
    }
}
