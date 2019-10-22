using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{

    /// <summary>
    /// Class StorageKorisnik represents data of objects from class Korisnik stored
    /// in operative memory.
    /// </summary>
    public class StorageKorisnik
    {

        /// <summary>
        /// Data structure for objects from class Korisnik.
        /// </summary>
        private List<Korisnik> korisnici;



        /// <summary>
        ///     Makes an instance of korisnici.
        /// </summary>
        public StorageKorisnik()
        {
            korisnici = new List<Korisnik>() 
            { 
                new Korisnik() 
                {
                    Ime = "pera", 
                    Prezime = "peric", 
                    Email = "pera@gmail.com",
                    KorisnickoIme = "pera",
                    Password = "pera"
                } 
            };
        }



        /// <summary>
        /// Returns the data stored in operative memory.
        /// </summary>
        /// <returns>Data stored in operative memory.</returns>
        public List<Korisnik> vratiKorisnike()
        {
            return korisnici;
        }
    }
}
