using Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromLogIn
{
    static class Program
    {
        
        public static void Main()
        {
            //FrmLogIn frmLogIn = new FrmLogIn();
            //frmLogIn.ShowDialog();

            string sifra = "Prsten";
            Console.WriteLine($"Inicijalizovana sifra: {sifra}");

            string secretKey = EncryptionDecryptionHandler.GenerateEncryptionKey();

            string kriptovanaSifra = EncryptionDecryptionHandler.EncryptString(sifra, secretKey);

            Console.WriteLine($"Kriptovana sifra: {kriptovanaSifra}");

            string dekriptovanaSifra = EncryptionDecryptionHandler.DecryptString(kriptovanaSifra, secretKey);

            Console.WriteLine($"Dekriptovana sifra: {dekriptovanaSifra}");

        }
    }
}
