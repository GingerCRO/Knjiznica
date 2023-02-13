using Knjiznica.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knjiznica
{
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        public PodatkovniKontekst kontekst;

        private void Glavna_Load(object sender, EventArgs e)
        {

            try
            {
                kontekst = new PodatkovniKontekst();

                DataRefresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void DataRefresh()
        {

            kontekst.SpremiPosudbe();
            lbPosudbe.Items.Clear();
            kontekst.Posudbe.Sort();

            foreach (Posudba item in kontekst.Posudbe)
            {
                lbPosudbe.Items.Add(item);
            }

        }

        private void učeniciToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Ucenici frmUcenici = new Ucenici(kontekst);

            frmUcenici.ShowDialog();

        }

        private void knjigeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Knjige frmKnjige = new Knjige(kontekst);

            frmKnjige.ShowDialog();

        }

        private void btnVrati_Click(object sender, EventArgs e)
        {

            if (lbPosudbe.SelectedIndex < 0)
            {
                MessageBox.Show("Niste odabrali posudbu");
            }
            else
            {
                kontekst.BrisiPosudbu((Posudba)lbPosudbe.SelectedItem);

                DataRefresh(); 
            }

        }

        private void btnPosudi_Click(object sender, EventArgs e)
        {

            PDetalji pDetalji = new PDetalji(kontekst);

            if (pDetalji.ShowDialog() == DialogResult.OK)
            {
                kontekst.Posudbe.Add(pDetalji.posudba);
                DataRefresh();
            }

        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {

            if (lbPosudbe.SelectedIndex < 0)
            {
                MessageBox.Show("Odaberi posudbu");
            }
            else
            {
                PDetalji pDetalji = new PDetalji(kontekst);

                pDetalji.posudba = (Posudba)lbPosudbe.SelectedItem;

                if (pDetalji.ShowDialog() == DialogResult.OK)
                {
                    DataRefresh();
                }
            }

        }
    }
}
