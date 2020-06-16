using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace al_4
{
    abstract class System
    {
        private Telo t1;

        
        public System( Telo t2)
        {
            t1 = t2;
        }

        
        public Telo t
        {
            get { return t1; }
            set { t1 = value; }
        }

        public abstract System Clone();
    }
    }

