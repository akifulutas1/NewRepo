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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_pw_TextChanged(object sender, EventArgs e)
        {
            tb_pw.UseSystemPasswordChar = true;
        }

        private void btn_bestaetigen_Click(object sender, EventArgs e)
        {
            if (tb_user.Text.ToLower() == "admin" && tb_pw.Text == "admin")
            {
                Hauptmenü startseite = new Hauptmenü();
                this.Hide();
                startseite.Show();
            }

            else
            {

            }
        }
    }
}
