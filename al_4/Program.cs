using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace al_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Telo tel1 = new Telo(20, "символы");
            System s1 = new ConcretePrototype1(tel1);
            System c1 = s1.Clone();

            c1.t.DLINA = 12;
            c1.t.NAME = "хорошая работа";

            Console.WriteLine("Dlina: {0} Name: {1}", c1.t.DLINA, c1.t.NAME);

            Console.WriteLine("Dlina: {0} Name: {1}", s1.t.DLINA, s1.t.NAME);

            Telo tel2 = new Telo(75, "новый год");
            System s2 = new ConcretePrototype2(tel2);
            System c2 = s2.Clone();

            c2.t.DLINA = 13;
            c2.t.NAME = "молодец настя";

            Console.WriteLine("Dlina: {0} Name: {1}", c2.t.DLINA, c2.t.NAME);
            Console.WriteLine("Dlina: {0} Name: {1}", s2.t.DLINA, s2.t.NAME);
            Console.Read();
        }
    }
}
