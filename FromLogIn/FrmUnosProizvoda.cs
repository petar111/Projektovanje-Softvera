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
    public partial class FrmUnosProizvoda : Form
    {
        private KontrolerPrograma contorler = new KontrolerPrograma();
        public FrmUnosProizvoda()
        {
            InitializeComponent();
        }

        private void FrmUnosProizvoda_Load(object sender, EventArgs e)
        {
            cboxProizvodjaci.DataSource = contorler.vratiSveProizvodjace();
            txtID.Text = Convert.ToString(contorler.VratiNoviIdProizvoda());
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            Proizvod p = new Proizvod();

            try
            {
                if ((p.ID = contorler.VratiNoviIdProizvoda()) == -1)
                {
                    MessageBox.Show("Greska sa bazom!");
                    return;
                }


                if (string.IsNullOrEmpty(txtNaziv.Text))
                {
                    MessageBox.Show("Prazan naziv!");
                    return;
                }
                p.Ime = txtNaziv.Text;

                p.Cena = double.Parse(txtCena.Text);

                p.Proizvodjac = (Proizvodjac)cboxProizvodjaci.SelectedItem;

                if (contorler.SacuvajProizvod(p))
                {
                    MessageBox.Show("Uspesno sacuvan proizvod!");
                    txtID.Text = Convert.ToString(contorler.VratiNoviIdProizvoda());
                }
                else
                {
                    MessageBox.Show("Proizvod nije sacuvan!");
                }

                txtCena.Text = "";
                txtNaziv.Text = "";
            }
            catch (FormatException fe)
            {

                MessageBox.Show("Greska pri unosu! " + fe.Message);
            }

        }
    }
}
