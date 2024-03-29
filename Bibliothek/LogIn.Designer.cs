namespace Bibliothek
{
    partial class LogIn
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.login_label = new System.Windows.Forms.Label();
            this.bestaetigen_btn = new System.Windows.Forms.Button();
            this.passwort_label = new System.Windows.Forms.Label();
            this.benutzername_label = new System.Windows.Forms.Label();
            this.tb_pw = new System.Windows.Forms.TextBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.login_label);
            this.panel1.Controls.Add(this.bestaetigen_btn);
            this.panel1.Controls.Add(this.passwort_label);
            this.panel1.Controls.Add(this.benutzername_label);
            this.panel1.Controls.Add(this.tb_pw);
            this.panel1.Controls.Add(this.tb_user);
            this.panel1.Location = new System.Drawing.Point(24, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 371);
            this.panel1.TabIndex = 0;
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.ForeColor = System.Drawing.Color.Red;
            this.login_label.Location = new System.Drawing.Point(272, 39);
            this.login_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(126, 51);
            this.login_label.TabIndex = 1;
            this.login_label.Text = "Login";
            // 
            // bestaetigen_btn
            // 
            this.bestaetigen_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestaetigen_btn.ForeColor = System.Drawing.Color.Red;
            this.bestaetigen_btn.Location = new System.Drawing.Point(281, 291);
            this.bestaetigen_btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bestaetigen_btn.Name = "bestaetigen_btn";
            this.bestaetigen_btn.Size = new System.Drawing.Size(138, 40);
            this.bestaetigen_btn.TabIndex = 7;
            this.bestaetigen_btn.Text = "Bestätigen";
            this.bestaetigen_btn.UseVisualStyleBackColor = true;
            this.bestaetigen_btn.Click += new System.EventHandler(this.btn_bestaetigen_Click);
            // 
            // passwort_label
            // 
            this.passwort_label.AutoSize = true;
            this.passwort_label.Font = new System.Drawing.Font("Bahnschrift", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwort_label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.passwort_label.Location = new System.Drawing.Point(84, 230);
            this.passwort_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.passwort_label.Name = "passwort_label";
            this.passwort_label.Size = new System.Drawing.Size(130, 33);
            this.passwort_label.TabIndex = 5;
            this.passwort_label.Text = "Passwort";
            // 
            // benutzername_label
            // 
            this.benutzername_label.AutoSize = true;
            this.benutzername_label.Font = new System.Drawing.Font("Bahnschrift", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.benutzername_label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.benutzername_label.Location = new System.Drawing.Point(84, 144);
            this.benutzername_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.benutzername_label.Name = "benutzername_label";
            this.benutzername_label.Size = new System.Drawing.Size(190, 33);
            this.benutzername_label.TabIndex = 4;
            this.benutzername_label.Text = "Benutzername";
            this.benutzername_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_pw
            // 
            this.tb_pw.Location = new System.Drawing.Point(305, 234);
            this.tb_pw.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.Size = new System.Drawing.Size(278, 31);
            this.tb_pw.TabIndex = 3;
            this.tb_pw.TextChanged += new System.EventHandler(this.tb_pw_TextChanged);
            // 
            // tb_user
            // 
            this.tb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_user.Location = new System.Drawing.Point(305, 140);
            this.tb_user.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(278, 37);
            this.tb_user.TabIndex = 1;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 417);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "LogIn";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label passwort_label;
        private System.Windows.Forms.Label benutzername_label;
        private System.Windows.Forms.TextBox tb_pw;
        private System.Windows.Forms.Button bestaetigen_btn;
        private System.Windows.Forms.Label login_label;
    }
}

