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

        

    }
}
