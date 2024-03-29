using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliothek
{
    public partial class Bibliotheksmanagement : Form
    {
        public Bibliotheksmanagement()
        {
            InitializeComponent();
            this.CenterToScreen();

            List<Buch> buchListe = new List<Buch>();
        }

        private void btn_zurueck_Click(object sender, EventArgs e)
        {
            Hauptmenü startseite = new Hauptmenü();
            this.Close();
            startseite.Show();

        }

        private void btn_hinzufügen_Click(object sender, EventArgs e)
        {

        }
    }
}
