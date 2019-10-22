using BrokerBazePodataka;
using Domain;
using Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontroler
{
    public class KontrolerPrograma
    {
        private Broker broker = new Broker();
        public static Korisnik LogIn(string korIme, string sifra)
        {
            List<Korisnik> korisnici = new StorageKorisnik().vratiKorisnike();

            foreach (var kor in korisnici)
            {
                if(kor.KorisnickoIme == korIme && kor.Password == sifra)
                {
                    return kor;
                }
            }
            return null;
        }

        public int VratiNoviIdProizvoda()
        {
            return broker.VratiNoviIdProizvoda();
        }

        public List<Proizvodjac> vratiSveProizvodjace()
        {
            return broker.vratiSveProizvodjace();
        }

        public bool SacuvajProizvod(Proizvod p)
        {
            return broker.SacuvajProizvod(p);
        }
    }
}
