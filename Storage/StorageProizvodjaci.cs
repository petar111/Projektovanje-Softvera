using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public class StorageProizvodjaci
    {
        private List<Proizvodjac> proizvodjaci;

        public StorageProizvodjaci()
        {
            proizvodjaci = new List<Proizvodjac>();
        }

        public List<Proizvodjac> vratiSveProizvodjace()
        {
            return proizvodjaci;
        }
    }
}
