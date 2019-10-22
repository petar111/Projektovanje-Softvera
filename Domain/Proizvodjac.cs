using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Proizvodjac
    {

        public int IDProizvodjaca { get; set; }
        public string NazivProizvodjaca { get; set; }

        public override string ToString()
        {
            return NazivProizvodjaca.Trim();
        }

    }
}
