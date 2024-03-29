namespace Bibliothek
{
    partial class Kundenverwaltung
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
            this.kundenverwaltung_label = new System.Windows.Forms.Label();
            this.löschen_btn = new System.Windows.Forms.Button();
            this.bearbeiten_btn = new System.Windows.Forms.Button();
            this.hinzufügen_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KundenID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nachname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Straße = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hausnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mitgliedsstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // zurück_btn
            // 
            this.zurück_btn.Font = new System.Drawing.Font("Bahnschrift", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zurück_btn.Location = new System.Drawing.Point(1164, 115);
            this.zurück_btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.zurück_btn.Name = "zurück_btn";
            this.zurück_btn.Size = new System.Drawing.Size(338, 56);
            this.zurück_btn.TabIndex = 24;
            this.zurück_btn.Text = "Zurück";
            this.zurück_btn.UseVisualStyleBackColor = true;
            this.zurück_btn.Click += new System.EventHandler(this.btn_zurück_Click);
            // 
            // kundenverwaltung_label
            // 
            this.kundenverwaltung_label.AutoSize = true;
            this.kundenverwaltung_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kundenverwaltung_label.ForeColor = System.Drawing.Color.Red;
            this.kundenverwaltung_label.Location = new System.Drawing.Point(607, 25);
            this.kundenverwaltung_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.kundenverwaltung_label.Name = "kundenverwaltung_label";
            this.kundenverwaltung_label.Size = new System.Drawing.Size(374, 51);
            this.kundenverwaltung_label.TabIndex = 22;
            this.kundenverwaltung_label.Text = "Kundenverwaltung";
            // 
            // löschen_btn
            // 
            this.löschen_btn.Font = new System.Drawing.Font("Bahnschrift", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.löschen_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.löschen_btn.Location = new System.Drawing.Point(784, 115);
            this.löschen_btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.löschen_btn.Name = "löschen_btn";
            this.löschen_btn.Size = new System.Drawing.Size(338, 56);
            this.löschen_btn.TabIndex = 21;
            this.löschen_btn.Text = "Kunde löschen";
            this.löschen_btn.UseVisualStyleBackColor = true;
            // 
            // bearbeiten_btn
            // 
            this.bearbeiten_btn.Font = new System.Drawing.Font("Bahnschrift", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bearbeiten_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bearbeiten_btn.Location = new System.Drawing.Point(405, 115);
            this.bearbeiten_btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bearbeiten_btn.Name = "bearbeiten_btn";
            this.bearbeiten_btn.Size = new System.Drawing.Size(338, 56);
            this.bearbeiten_btn.TabIndex = 20;
            this.bearbeiten_btn.Text = "Kunde bearbeiten";
            this.bearbeiten_btn.UseVisualStyleBackColor = true;
            // 
            // hinzufügen_btn
            // 
            this.hinzufügen_btn.Font = new System.Drawing.Font("Bahnschrift", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hinzufügen_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.hinzufügen_btn.Location = new System.Drawing.Point(38, 113);
            this.hinzufügen_btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.hinzufügen_btn.Name = "hinzufügen_btn";
            this.hinzufügen_btn.Size = new System.Drawing.Size(339, 56);
            this.hinzufügen_btn.TabIndex = 19;
            this.hinzufügen_btn.Text = "Kunde hinzufügen";
            this.hinzufügen_btn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KundenID,
            this.Nachname,
            this.Vorname,
            this.Straße,
            this.Hausnummer,
            this.PLZ,
            this.Mitgliedsstatus});
            this.dataGridView1.Location = new System.Drawing.Point(38, 183);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(1485, 587);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // KundenID
            // 
            this.KundenID.HeaderText = "KundenID";
            this.KundenID.MinimumWidth = 10;
            this.KundenID.Name = "KundenID";
            this.KundenID.Width = 200;
            // 
            // Nachname
            // 
            this.Nachname.HeaderText = "Nachname";
            this.Nachname.MinimumWidth = 10;
            this.Nachname.Name = "Nachname";
            this.Nachname.Width = 200;
            // 
            // Vorname
            // 
            this.Vorname.HeaderText = "Vorname";
            this.Vorname.MinimumWidth = 10;
            this.Vorname.Name = "Vorname";
            this.Vorname.Width = 200;
            // 
            // Straße
            // 
            this.Straße.HeaderText = "Straße";
            this.Straße.MinimumWidth = 10;
            this.Straße.Name = "Straße";
            this.Straße.Width = 200;
            // 
            // Hausnummer
            // 
            this.Hausnummer.HeaderText = "Hausnummer";
            this.Hausnummer.MinimumWidth = 10;
            this.Hausnummer.Name = "Hausnummer";
            this.Hausnummer.Width = 200;
            // 
            // PLZ
            // 
            this.PLZ.HeaderText = "PLZ";
            this.PLZ.MinimumWidth = 10;
            this.PLZ.Name = "PLZ";
            this.PLZ.Width = 200;
            // 
            // Mitgliedsstatus
            // 
            this.Mitgliedsstatus.HeaderText = "Mitgliedsstatus";
            this.Mitgliedsstatus.MinimumWidth = 10;
            this.Mitgliedsstatus.Name = "Mitgliedsstatus";
            this.Mitgliedsstatus.Width = 200;
            // 
            // Kundenverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 852);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.zurück_btn);
            this.Controls.Add(this.kundenverwaltung_label);
            this.Controls.Add(this.löschen_btn);
            this.Controls.Add(this.bearbeiten_btn);
            this.Controls.Add(this.hinzufügen_btn);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Kundenverwaltung";
            this.Text = "Kundenverwaltung";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zurück_btn;
        private System.Windows.Forms.Label kundenverwaltung_label;
        private System.Windows.Forms.Button löschen_btn;
        private System.Windows.Forms.Button bearbeiten_btn;
        private System.Windows.Forms.Button hinzufügen_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KundenID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nachname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Straße;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hausnummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mitgliedsstatus;
    }
}