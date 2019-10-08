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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }


        public FrmMain(Domain.Korisnik curr)
        {
            InitializeComponent();
            lblPrijavljeniKorisnik.Text = "Prijavljeni korisnik: " + $"{curr.Ime} {curr.Prezime}";
        }
    }
}
