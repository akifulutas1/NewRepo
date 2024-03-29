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
    public partial class Kundenverwaltung : Form
    {
        public Kundenverwaltung()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_zurück_Click(object sender, EventArgs e)
        {
            Hauptmenü startseite = new Hauptmenü();
            this.Close();
            startseite.Show();
        }
    }
}
