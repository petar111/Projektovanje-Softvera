using Domain;
using Kontroler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromLogIn
{
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string korIme = txtKorsinickoIme.Text;
            string pass = txtPassword.Text;


            Korisnik curr = KontrolerPrograma.LogIn(korIme, pass);

            if(curr != null)
            {
                MessageBox.Show("Uspesno logovanje");
                FrmMain frmMain = new FrmMain(curr);
                frmMain.ShowDialog();
            }
            else
            {
                MessageBox.Show("Logovanje nije uspelo.");
            }


            
        }

        
    }
}
