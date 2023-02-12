using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knjiznica.Forme
{
    public partial class Knjige : Form
    {

        private PodatkovniKontekst kontekst;

        public Knjige(PodatkovniKontekst _kontekst)
        {
            InitializeComponent();
            kontekst = _kontekst;
        }

        private void Knjige_Load(object sender, EventArgs e)
        {

            try
            {
                kontekst = new PodatkovniKontekst();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            DataRefresh();

        }

        private void DataRefresh()
        {

            kontekst.SpremiKnjige();

            lbKnjige.Items.Clear();

            kontekst.Knjige.Sort();

            foreach (Knjiga k in kontekst.Knjige)
            {
                lbKnjige.Items.Add(k);
            }

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            KDetalji frmDetalji = new KDetalji();

            if (frmDetalji.ShowDialog() == DialogResult.OK)
            {
                kontekst.Knjige.Add(frmDetalji.K);

                DataRefresh();
            }

        }

        private void btnUredi_Click(object sender, EventArgs e)
        {

            if (lbKnjige.SelectedIndex < 0)
            {
                MessageBox.Show("Niste odabrali knjigu");
            }
            else
            {

                KDetalji frmKDetalji = new KDetalji();

                frmKDetalji.K = (Knjiga)lbKnjige.SelectedItem;

                if (frmKDetalji.ShowDialog() == DialogResult.OK)
                {
                    DataRefresh();
                }

            }

        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {

            if (lbKnjige.SelectedIndex < 0)
            {
                MessageBox.Show("Niste odabrali knjigu");
            }
            else
            {
                kontekst.BrisiKnjigu((Knjiga)lbKnjige.SelectedItem);

                DataRefresh();
            }

        }
    }
}
