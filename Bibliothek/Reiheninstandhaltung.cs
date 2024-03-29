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
    public partial class Reiheninstandhaltung : Form
    {
        public Reiheninstandhaltung()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btn_zurück_Click(object sender, EventArgs e)
        {
            Hauptmenü startseite = new Hauptmenü();
            this.Close();
            startseite.Show();
        }
    }
}
