using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{

    /// <summary>
    /// Class Proizvod represents the oo model of relation Proizvod in relation system.
    /// </summary>
    public class Proizvod
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public double Cena { get; set; }

        public Proizvodjac Proizvodjac { get; set; }
    }
}
