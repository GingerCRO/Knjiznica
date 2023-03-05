using System;
using System.Windows.Forms;

namespace Knjiznica.Forme
{
    public partial class PDetalji : Form
    {

        PodatkovniKontekst kontekst;
        public Posudba posudba;

        public PDetalji(PodatkovniKontekst _kontekst)
        {
            InitializeComponent();
            kontekst = _kontekst;
        }

        private void PDetalji_Load(object sender, EventArgs e)
        {

            foreach (Ucenik u in kontekst.Ucenici)
            {
                lbUcenik.Items.Add(u);
            }

            foreach (Knjiga k in kontekst.Knjige)
            {
                lbKnjiga.Items.Add(k);
            }

            txtBroj.Text = "30";

            if (posudba != null)
            {

                int i = 0;

                i = lbUcenik.FindString(posudba.Ucenik.ToString());
                lbUcenik.SetSelected(i, true);

                i = lbKnjiga.FindString(posudba.Knjiga.ToString());
                lbKnjiga.SetSelected(i, true);

                dateTimePicker1.Value = posudba.DatumPosudbe;
                txtBroj.Text = posudba.BrojDana.ToString();

            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (lbUcenik.SelectedIndex < 0 || lbKnjiga.SelectedIndex < 0)
            {
                MessageBox.Show("Morate odabrati učenika i knjigu");
            }

            else
            {

                if (posudba == null)
                {
                    posudba = new Posudba();
                }

                posudba.Ucenik = (Ucenik)lbUcenik.SelectedItem;
                posudba.Knjiga = (Knjiga)lbKnjiga.SelectedItem;
                posudba.DatumPosudbe = dateTimePicker1.Value;
                posudba.BrojDana = int.Parse(txtBroj.Text);

                DialogResult = DialogResult.OK;
            
            }
        }
    }
}
