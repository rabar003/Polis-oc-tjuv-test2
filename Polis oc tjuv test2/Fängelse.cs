using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polis_oc_tjuv_1
{
    public class Fängelse
    {
        public List<Tjuv> Fångar { get; private set; }

        public Fängelse()
        {
            Fångar = new List<Tjuv>();
        }

        public void LäggTillFånge(Tjuv tjuv)
        {
            Fångar.Add(tjuv);
            Console.WriteLine("Tjuven har placerats i fängelse.");
        }
    }
}
