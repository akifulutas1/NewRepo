namespace Bibliothek
{
    partial class Ausleihmanagement
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
            this.ausleihverwaltung_label = new System.Windows.Forms.Label();
            this.auslieheloeschen_btn = new System.Windows.Forms.Button();
            this.ausleihebearbeiten_btn = new System.Windows.Forms.Button();
            this.ausleihehinzufügen_btn = new System.Windows.Forms.Button();
            this.dGV_ausleihverwaltung = new System.Windows.Forms.DataGridView();
            this.BuchreihenID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buchreihenname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buch1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buch2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buch3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ausleihverwaltung)).BeginInit();
            this.SuspendLayout();
            // 
            // zurück_btn
            // 
            this.zurück_btn.Font = new System.Drawing.Font("Bahnschrift", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zurück_btn.Location = new System.Drawing.Point(1183, 100);
            this.zurück_btn.Margin = new System.Windows.Forms.Padding(6);
            this.zurück_btn.Name = "zurück_btn";
            this.zurück_btn.Size = new System.Drawing.Size(338, 56);
            this.zurück_btn.TabIndex = 18;
            this.zurück_btn.Text = "Zurück";
            this.zurück_btn.UseVisualStyleBackColor = true;
            this.zurück_btn.Click += new System.EventHandler(this.btn_zurück_Click);
            // 
            // ausleihverwaltung_label
            // 
            this.ausleihverwaltung_label.AutoSize = true;
            this.ausleihverwaltung_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ausleihverwaltung_label.ForeColor = System.Drawing.Color.Red;
            this.ausleihverwaltung_label.Location = new System.Drawing.Point(639, 19);
            this.ausleihverwaltung_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ausleihverwaltung_label.Name = "ausleihverwaltung_label";
            this.ausleihverwaltung_label.Size = new System.Drawing.Size(373, 51);
            this.ausleihverwaltung_label.TabIndex = 16;
            this.ausleihverwaltung_label.Text = "Ausleihverwaltung";
            this.ausleihverwaltung_label.Click += new System.EventHandler(this.lbl_Verwaltung_Click);
            // 
            // auslieheloeschen_btn
            // 
            this.auslieheloeschen_btn.Font = new System.Drawing.Font("Bahnschrift", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auslieheloeschen_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.auslieheloeschen_btn.Location = new System.Drawing.Point(786, 100);
            this.auslieheloeschen_btn.Margin = new System.Windows.Forms.Padding(6);
            this.auslieheloeschen_btn.Name = "auslieheloeschen_btn";
            this.auslieheloeschen_btn.Size = new System.Drawing.Size(338, 56);
            this.auslieheloeschen_btn.TabIndex = 15;
            this.auslieheloeschen_btn.Text = "Ausleihe löschen";
            this.auslieheloeschen_btn.UseVisualStyleBackColor = true;
            // 
            // ausleihebearbeiten_btn
            // 
            this.ausleihebearbeiten_btn.Font = new System.Drawing.Font("Bahnschrift", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ausleihebearbeiten_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ausleihebearbeiten_btn.Location = new System.Drawing.Point(415, 100);
            this.ausleihebearbeiten_btn.Margin = new System.Windows.Forms.Padding(6);
            this.ausleihebearbeiten_btn.Name = "ausleihebearbeiten_btn";
            this.ausleihebearbeiten_btn.Size = new System.Drawing.Size(338, 56);
            this.ausleihebearbeiten_btn.TabIndex = 14;
            this.ausleihebearbeiten_btn.Text = "Ausleihe bearbeiten";
            this.ausleihebearbeiten_btn.UseVisualStyleBackColor = true;
            // 
            // ausleihehinzufügen_btn
            // 
            this.ausleihehinzufügen_btn.Font = new System.Drawing.Font("Bahnschrift", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ausleihehinzufügen_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ausleihehinzufügen_btn.Location = new System.Drawing.Point(55, 100);
            this.ausleihehinzufügen_btn.Margin = new System.Windows.Forms.Padding(6);
            this.ausleihehinzufügen_btn.Name = "ausleihehinzufügen_btn";
            this.ausleihehinzufügen_btn.Size = new System.Drawing.Size(338, 56);
            this.ausleihehinzufügen_btn.TabIndex = 13;
            this.ausleihehinzufügen_btn.Text = "Ausleihe hinzufügen";
            this.ausleihehinzufügen_btn.UseVisualStyleBackColor = true;
            // 
            // dGV_ausleihverwaltung
            // 
            this.dGV_ausleihverwaltung.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dGV_ausleihverwaltung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_ausleihverwaltung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BuchreihenID,
            this.Buchreihenname,
            this.Buch1,
            this.Buch2,
            this.Buch3});
            this.dGV_ausleihverwaltung.Location = new System.Drawing.Point(55, 168);
            this.dGV_ausleihverwaltung.Margin = new System.Windows.Forms.Padding(6);
            this.dGV_ausleihverwaltung.Name = "dGV_ausleihverwaltung";
            this.dGV_ausleihverwaltung.RowHeadersWidth = 82;
            this.dGV_ausleihverwaltung.Size = new System.Drawing.Size(1466, 520);
            this.dGV_ausleihverwaltung.TabIndex = 22;
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
            // Ausleihmanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 703);
            this.Controls.Add(this.dGV_ausleihverwaltung);
            this.Controls.Add(this.zurück_btn);
            this.Controls.Add(this.ausleihverwaltung_label);
            this.Controls.Add(this.auslieheloeschen_btn);
            this.Controls.Add(this.ausleihebearbeiten_btn);
            this.Controls.Add(this.ausleihehinzufügen_btn);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Ausleihmanagement";
            this.Text = "Ausleihverwaltung";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ausleihverwaltung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zurück_btn;
        private System.Windows.Forms.Label ausleihverwaltung_label;
        private System.Windows.Forms.Button auslieheloeschen_btn;
        private System.Windows.Forms.Button ausleihebearbeiten_btn;
        private System.Windows.Forms.Button ausleihehinzufügen_btn;
        private System.Windows.Forms.DataGridView dGV_ausleihverwaltung;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuchreihenID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buchreihenname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buch1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buch2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buch3;
    }
}