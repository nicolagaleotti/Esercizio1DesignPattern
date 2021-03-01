using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1DesignPattern
{
    public class Riga
    {
        List<Cella> celle = new List<Cella>();

        internal Riga() { }

        public Cella NuovaCella()
        {
            Cella c = new Cella();
            celle.Add(c);
            return c;
        }
    }
}
