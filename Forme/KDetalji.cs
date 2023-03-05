using System;
using System.Windows.Forms;

namespace Knjiznica.Forme
{
    public partial class KDetalji : Form
    {

        public Knjiga K;

        public KDetalji()
        {
            InitializeComponent();
        }

        private void KDetalji_Load(object sender, EventArgs e)
        {

            if (K != null)
            {

                txtISBN.Text = K.ISBN;
                txtAutor.Text = K.Autor;
                txtNaslov.Text = K.Naslov;
                txtGodinaIzdanja.Text = K.GodinaIzdanja.ToString();
                txtBrojPrimjeraka.Text = K.BrojPrimjeraka.ToString();

            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (txtISBN.Text == "" || txtAutor.Text == "" || txtNaslov.Text == "" || txtGodinaIzdanja.Text == "" || txtBrojPrimjeraka.Text == "")
            {
                MessageBox.Show("ISBN, autor, naslov, godina izdanja i broj primjeraka su obavezni!");
            }
            else
            {

                if (K == null)
                {
                    K = new Knjiga();
                }

                K.ISBN = txtISBN.Text;
                K.Autor = txtAutor.Text;
                K.Naslov = txtNaslov.Text;
                K.GodinaIzdanja = int.Parse(txtGodinaIzdanja.Text);
                K.BrojPrimjeraka = int.Parse(txtBrojPrimjeraka.Text);                

                DialogResult = DialogResult.OK;

            }

        }
    }
}
