using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public class StorageKorisnik
    {
        private List<Korisnik> korisnici;

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


        public List<Korisnik> vratiKorisnike()
        {
            return korisnici;
        }
    }
}
