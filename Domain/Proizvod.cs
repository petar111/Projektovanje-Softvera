using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Proizvod
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public double Cena { get; set; }

        public Proizvodjac Proizvodjac { get; set; }
    }
}
