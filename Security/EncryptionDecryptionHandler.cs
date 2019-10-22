using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Security
{
    /// <summary>
    /// Class EncryptionDecryptionHandler represents
    /// ecryption and decryption of some object with symetric encryption algorithm
    /// using derived key method.
    /// </summary>
    public static class EncryptionDecryptionHandler
    {

        /// <summary>
        /// Generates encryption key.
        /// </summary>
        /// <returns>Encryption key.</returns>
        public static string GenerateEncryptionKey()
        {
            Random ran = new Random();
            byte[] tmpBytes = new byte[10];
            ran.NextBytes(tmpBytes);

            string tmpString = Encoding.Unicode.GetString(tmpBytes);      

            
            return tmpString + ran.Next().ToString();
        }


        /// <summary>
        /// Encrypts a string.
        /// </summary>
        /// <param name="text">String to be encrypted.</param>
        /// <param name="encKey">Encryption key.</param>
        /// <returns>Encrypted string.</returns>
        public static string EncryptString(string text, string encKey)
        {
            //Pretvara string u niz bajtova.
            byte[] textB = Encoding.Unicode.GetBytes(text);


            //Instancira objekat klase Aes koji ce koristiti metodu simetricnog kriptovanja u skladu sa Advanced Encryption Standards.
            using (Aes aes = Aes.Create())
            {
                //Instancira objekat klase koja ce enkriptovati string koriscenjem metode izvedenog kljuca.
                Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(encKey, new byte[] {0x22, 0x31, 0x54, 0x75, 0x99, 0x98, 0x7A, 0x4D });

                //Postavljanje vrednosti tajnog kljuca i pocetnog vektora
                aes.Key = rfc.GetBytes(32);
                aes.IV = rfc.GetBytes(16);


                //Otvaranje toka bajtova u operativnoj memoriji i kompozicija sa Crypto tokom koji ce nam omoguciti da upisemo enkriptovani niz bajtova
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(textB, 0, textB.Length);
                        cs.Close();
                    }

                    text = Convert.ToBase64String(ms.ToArray());
                }

            }

            return text;

        }


        /// <summary>
        /// Decrypts cypered string.
        /// </summary>
        /// <param name="cipher">Cypher to be decrypted</param>
        /// <param name="encKey">Encryption key for decryption.</param>
        /// <returns>Decrypred string.</returns>
        public static string DecryptString(string cipher, string encKey)
        {
            //Pretvara string u niz bajtova.
            byte[] textB = Convert.FromBase64String(cipher);


            //Instancira objekat klase Aes koji ce koristiti metodu simetricnog kriptovanja u skladu sa Advanced Encryption Standards.
            using (Aes aes = Aes.Create())
            {
                //Instancira objekat klase koja ce dekriptovati string koriscenjem metode izvedenog kljuca.
                Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(encKey, new byte[] { 0x22, 0x31, 0x54, 0x75, 0x99, 0x98, 0x7A, 0x4D });


                //Postavljanje vrednosti tajnog kljuca i pocetnog vektora
                aes.Key = rfc.GetBytes(32);
                aes.IV = rfc.GetBytes(16);

                //Otvaranje toka bajtova u operativnoj memoriji i kompozicija sa Crypto tokom koji ce nam omoguciti da upisemo dekriptovani niz bajtova
                using (MemoryStream ms = new MemoryStream())
                {

                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(textB, 0, textB.Length);
                        cs.Close();
                    }

                    cipher = Encoding.Unicode.GetString(ms.ToArray());
                }

            }

            return cipher;

        }
    }
}
