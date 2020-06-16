using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace al_4
{
    class ConcretePrototype2:System
    {
        public ConcretePrototype2(Telo t2)
            : base(t2)
        {
        }

        public override System Clone()
        {
            return new ConcretePrototype2(new Telo(t.DLINA, t.NAME));
        }
    }
}
