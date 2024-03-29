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
    public partial class Hauptmenü : Form
    {
        public Hauptmenü()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btn_buecherverwalten_Click(object sender, EventArgs e)
        {
            Bibliotheksmanagement buchverwaltung = new Bibliotheksmanagement();
            this.Hide();
            buchverwaltung.Show();
        }

        private void btn_buchreihenverwalten_Click(object sender, EventArgs e)
        {
            Reiheninstandhaltung buchreihenverwaltung = new Reiheninstandhaltung();
            this.Hide();
            buchreihenverwaltung.Show();
        }

        private void btn_kundenverwalten_Click(object sender, EventArgs e)
        {
            Kundenverwaltung kundenverwaltung = new Kundenverwaltung();
            this.Hide();
            kundenverwaltung.Show();
        }

        private void btn_ausleihenverwalten_Click(object sender, EventArgs e)
        {
            Ausleihmanagement ausleihverwaltung = new Ausleihmanagement();
            this.Hide();
            ausleihverwaltung.Show();
        }

      

      

  
    }
}
