using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Knjiznica.Forme;

namespace Knjiznica
{
    public partial class Ucenici : Form
    {

        private PodatkovniKontekst kontekst;

        public Ucenici(PodatkovniKontekst _kontekst)
        {
            InitializeComponent();
            kontekst = _kontekst;
        }

        private void Ucenici_Load(object sender, EventArgs e)
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

            kontekst.SpremiUcenike();

            lbUcenici.Items.Clear();

            kontekst.Ucenici.Sort();

            foreach (Ucenik u in kontekst.Ucenici)
            {
                lbUcenici.Items.Add(u);
            }

        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {

            if (lbUcenici.SelectedIndex < 0)
            {
                MessageBox.Show("Niste odabrali učenika");
            }
            else
            {
                kontekst.BrisiUcenika((Ucenik)lbUcenici.SelectedItem);

                DataRefresh();
            }

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {


            UDetalji frmDetalji = new UDetalji(); 

            if (frmDetalji.ShowDialog() == DialogResult.OK)
            {
                kontekst.Ucenici.Add(frmDetalji.U);

                DataRefresh();
            }

        }

        private void btnUredi_Click(object sender, EventArgs e)
        {


            if (lbUcenici.SelectedIndex < 0)
            {
                MessageBox.Show("Niste odabrali učenika");
            }
            else
            {

                UDetalji frmUDetalji = new UDetalji();

                frmUDetalji.U = (Ucenik)lbUcenici.SelectedItem;

                if (frmUDetalji.ShowDialog() == DialogResult.OK)
                {
                    DataRefresh();
                }

            }
        }
    }
}
