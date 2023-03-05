using System;
using System.Windows.Forms;

namespace Knjiznica.Forme
{
    public partial class UDetalji : Form
    {
        public UDetalji()
        {
            InitializeComponent();
        }

        public Ucenik U;

        private void UDetalji_Load(object sender, EventArgs e)
        {

            if (U != null)
            {

                txtOIB.Text = U.OIB;
                txtIme.Text = U.Ime;
                txtPrezime.Text = U.Prezime;
                txtAdresa.Text = U.Adresa;
                txtTelefon.Text = U.Telefon;
                cbRazred.Text = U.Razred.ToString();

            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (txtOIB.Text == "" || txtIme.Text == "" || txtPrezime.Text == "" || cbRazred.Text == "")
            {
                MessageBox.Show("OIB, ime, prezime i razred su obavezni!");
            }
            else
            {

                if (U == null)
                {
                    U = new Ucenik();
                }

                U.OIB = txtOIB.Text;
                U.Ime = txtIme.Text;
                U.Prezime = txtPrezime.Text;
                U.Adresa = txtAdresa.Text;
                U.Telefon = txtTelefon.Text;
                U.Razred = int.Parse(cbRazred.Text);

                DialogResult = DialogResult.OK;

            }

        }
    }
}
