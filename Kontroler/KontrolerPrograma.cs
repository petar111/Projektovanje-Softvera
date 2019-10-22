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

    /// <summary>
    ///     Class KontrolerPrograma represents logic of system operations or connection between 
    ///     user interface and calls from it and other parts of the system.
    /// </summary>
    public class KontrolerPrograma
    {

        /// <summary>
        /// Database broker. Does operations what manipulate database relations.
        /// </summary>
        private Broker broker = new Broker();

        /// <summary>
        /// Attempts to log in with specific user.
        /// </summary>
        /// <param name="korIme">Users username.</param>
        /// <param name="sifra">Users password</param>
        /// <returns>Instance of Korisnik if log in in was successful, null if log in was unsuccessful.</returns>
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


        /// <summary>
        /// Returns new id for relation Proizvod.
        /// </summary>
        /// <returns>New id for relation Proizvod.</returns>
        public int VratiNoviIdProizvoda()
        {
            return broker.VratiNoviIdProizvoda();
        }


        /// <summary>
        /// Returns all rows from relation Prozivodjac.
        /// </summary>
        /// <returns>All rows from relation Prozivodjac.</returns>
        public List<Proizvodjac> vratiSveProizvodjace()
        {
            return broker.vratiSveProizvodjace();
        }


        /// <summary>
        /// Attempts to insert row in relation Proizvod.
        /// </summary>
        /// <returns>True if insertion if successful, false otherwise</returns>
        public bool SacuvajProizvod(Proizvod p)
        {
            return broker.SacuvajProizvod(p);
        }
    }
}
