using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    /// <summary>
    /// Class Proizvodjac represents the oo model of relation Proizvodjac in relation system.
    /// </summary>

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
