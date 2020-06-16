using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace al_4
{
    class ConcretePrototype1: System
    {
         public ConcretePrototype1(Telo t2)
            : base(t2)
        {
        }

        public override System Clone()
        {
            // Shallow copy
            return (System)this.MemberwiseClone();
        }
    }
    }

