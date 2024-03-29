namespace Bibliothek
{
    partial class Reiheninstandhaltung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.zurück_btn = new System.Windows.Forms.Button();
            this.buchreiheverwaltung_btn = new System.Windows.Forms.Label();
            this.burchreiheloeschen_btn = new System.Windows.Forms.Button();
            this.buchreihebearbeiten_btn = new System.Windows.Forms.Button();
            this.buchreihehinzufügen_btn = new System.Windows.Forms.Button();
            this.dGV_buchreihenverwaltung = new System.Windows.Forms.DataGridView();
            this.BuchreihenID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buchreihenname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buch1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buch2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buch3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_buchreihenverwaltung)).BeginInit();
            this.SuspendLayout();
            // 
            // zurück_btn
            // 
            this.zurück_btn.Font = new System.Drawing.Font("Bahnschrift", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zurück_btn.Location = new System.Drawing.Point(1179, 128);
            this.zurück_btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.zurück_btn.Name = "zurück_btn";
            this.zurück_btn.Size = new System.Drawing.Size(338, 56);
            this.zurück_btn.TabIndex = 18;
            this.zurück_btn.Text = "Zurück";
            this.zurück_btn.UseVisualStyleBackColor = true;
            this.zurück_btn.Click += new System.EventHandler(this.btn_zurück_Click);
            // 
            // buchreiheverwaltung_btn
            // 
            this.buchreiheverwaltung_btn.AutoSize = true;
            this.buchreiheverwaltung_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buchreiheverwaltung_btn.ForeColor = System.Drawing.Color.Red;
            this.buchreiheverwaltung_btn.Location = new System.Drawing.Point(600, 29);
            this.buchreiheverwaltung_btn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.buchreiheverwaltung_btn.Name = "buchreiheverwaltung_btn";
            this.buchreiheverwaltung_btn.Size = new System.Drawing.Size(447, 51);
            this.buchreiheverwaltung_btn.TabIndex = 16;
            this.buchreiheverwaltung_btn.Text = "Buchreihenverwaltung";
            // 
            // burchreiheloeschen_btn
            // 
            this.burchreiheloeschen_btn.Font = new System.Drawing.Font("Bahnschrift", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burchreiheloeschen_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.burchreiheloeschen_btn.Location = new System.Drawing.Point(804, 128);
            this.burchreiheloeschen_btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.burchreiheloeschen_btn.Name = "burchreiheloeschen_btn";
            this.burchreiheloeschen_btn.Size = new System.Drawing.Size(338, 56);
            this.burchreiheloeschen_btn.TabIndex = 15;
            this.burchreiheloeschen_btn.Text = "Buchreihe löschen";
            this.burchreiheloeschen_btn.UseVisualStyleBackColor = true;
            // 
            // buchreihebearbeiten_btn
            // 
            this.buchreihebearbeiten_btn.Font = new System.Drawing.Font("Bahnschrift", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buchreihebearbeiten_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buchreihebearbeiten_btn.Location = new System.Drawing.Point(424, 128);
            this.buchreihebearbeiten_btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buchreihebearbeiten_btn.Name = "buchreihebearbeiten_btn";
            this.buchreihebearbeiten_btn.Size = new System.Drawing.Size(338, 56);
            this.buchreihebearbeiten_btn.TabIndex = 14;
            this.buchreihebearbeiten_btn.Text = "Buchreihe bearbeiten";
            this.buchreihebearbeiten_btn.UseVisualStyleBackColor = true;
            // 
            // buchreihehinzufügen_btn
            // 
            this.buchreihehinzufügen_btn.Font = new System.Drawing.Font("Bahnschrift", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buchreihehinzufügen_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buchreihehinzufügen_btn.Location = new System.Drawing.Point(40, 128);
            this.buchreihehinzufügen_btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buchreihehinzufügen_btn.Name = "buchreihehinzufügen_btn";
            this.buchreihehinzufügen_btn.Size = new System.Drawing.Size(338, 56);
            this.buchreihehinzufügen_btn.TabIndex = 13;
            this.buchreihehinzufügen_btn.Text = "Buchreihe hinzufügen";
            this.buchreihehinzufügen_btn.UseVisualStyleBackColor = true;
            // 
            // dGV_buchreihenverwaltung
            // 
            this.dGV_buchreihenverwaltung.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dGV_buchreihenverwaltung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_buchreihenverwaltung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BuchreihenID,
            this.Buchreihenname,
            this.Buch1,
            this.Buch2,
            this.Buch3});
            this.dGV_buchreihenverwaltung.Location = new System.Drawing.Point(40, 196);
            this.dGV_buchreihenverwaltung.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dGV_buchreihenverwaltung.Name = "dGV_buchreihenverwaltung";
            this.dGV_buchreihenverwaltung.RowHeadersWidth = 82;
            this.dGV_buchreihenverwaltung.Size = new System.Drawing.Size(1477, 545);
            this.dGV_buchreihenverwaltung.TabIndex = 19;
            // 
            // BuchreihenID
            // 
            this.BuchreihenID.HeaderText = "BuchreihenID";
            this.BuchreihenID.MinimumWidth = 10;
            this.BuchreihenID.Name = "BuchreihenID";
            this.BuchreihenID.Width = 200;
            // 
            // Buchreihenname
            // 
            this.Buchreihenname.HeaderText = "Buchreihenname";
            this.Buchreihenname.MinimumWidth = 10;
            this.Buchreihenname.Name = "Buchreihenname";
            this.Buchreihenname.Width = 200;
            // 
            // Buch1
            // 
            this.Buch1.HeaderText = "1. Buch";
            this.Buch1.MinimumWidth = 10;
            this.Buch1.Name = "Buch1";
            this.Buch1.Width = 200;
            // 
            // Buch2
            // 
            this.Buch2.HeaderText = "2. Buch";
            this.Buch2.MinimumWidth = 10;
            this.Buch2.Name = "Buch2";
            this.Buch2.Width = 200;
            // 
            // Buch3
            // 
            this.Buch3.HeaderText = "3. Buch";
            this.Buch3.MinimumWidth = 10;
            this.Buch3.Name = "Buch3";
            this.Buch3.Width = 200;
            // 
            // Reiheninstandhaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 736);
            this.Controls.Add(this.dGV_buchreihenverwaltung);
            this.Controls.Add(this.zurück_btn);
            this.Controls.Add(this.buchreiheverwaltung_btn);
            this.Controls.Add(this.burchreiheloeschen_btn);
            this.Controls.Add(this.buchreihebearbeiten_btn);
            this.Controls.Add(this.buchreihehinzufügen_btn);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Reiheninstandhaltung";
            this.Text = "Buchreihenverwaltung";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_buchreihenverwaltung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zurück_btn;
        private System.Windows.Forms.Label buchreiheverwaltung_btn;
        private System.Windows.Forms.Button burchreiheloeschen_btn;
        private System.Windows.Forms.Button buchreihebearbeiten_btn;
        private System.Windows.Forms.Button buchreihehinzufügen_btn;
        private System.Windows.Forms.DataGridView dGV_buchreihenverwaltung;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuchreihenID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buchreihenname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buch1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buch2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buch3;
    }
}