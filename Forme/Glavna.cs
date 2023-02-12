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
    }
}
