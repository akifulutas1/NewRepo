namespace Bibliothek
{
    partial class Bibliotheksmanagement
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
            this.btnhinzufügen_btn = new System.Windows.Forms.Button();
            this.buchbearbeiten_btn = new System.Windows.Forms.Button();
            this.buchlöschen_btn = new System.Windows.Forms.Button();
            this.Buchverwaltung_label = new System.Windows.Forms.Label();
            this.zurück_btn = new System.Windows.Forms.Button();
            this.Preiskategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Erscheinungsjahr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seitenzahl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGV_buchverwaltung = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_buchverwaltung)).BeginInit();
            this.SuspendLayout();
            // 
            // btnhinzufügen_btn
            // 
            this.btnhinzufügen_btn.Font = new System.Drawing.Font("Bahnschrift", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhinzufügen_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnhinzufügen_btn.Location = new System.Drawing.Point(44, 99);
            this.btnhinzufügen_btn.Margin = new System.Windows.Forms.Padding(6);
            this.btnhinzufügen_btn.Name = "btnhinzufügen_btn";
            this.btnhinzufügen_btn.Size = new System.Drawing.Size(338, 56);
            this.btnhinzufügen_btn.TabIndex = 1;
            this.btnhinzufügen_btn.Text = "Buch hinzufügen";
            this.btnhinzufügen_btn.UseVisualStyleBackColor = true;
            this.btnhinzufügen_btn.Click += new System.EventHandler(this.btn_hinzufügen_Click);
            // 
            // buchbearbeiten_btn
            // 
            this.buchbearbeiten_btn.Font = new System.Drawing.Font("Bahnschrift", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buchbearbeiten_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buchbearbeiten_btn.Location = new System.Drawing.Point(420, 99);
            this.buchbearbeiten_btn.Margin = new System.Windows.Forms.Padding(6);
            this.buchbearbeiten_btn.Name = "buchbearbeiten_btn";
            this.buchbearbeiten_btn.Size = new System.Drawing.Size(338, 56);
            this.buchbearbeiten_btn.TabIndex = 2;
            this.buchbearbeiten_btn.Text = "Buch bearbeiten";
            this.buchbearbeiten_btn.UseVisualStyleBackColor = true;
            // 
            // buchlöschen_btn
            // 
            this.buchlöschen_btn.Font = new System.Drawing.Font("Bahnschrift", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buchlöschen_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buchlöschen_btn.Location = new System.Drawing.Point(784, 99);
            this.buchlöschen_btn.Margin = new System.Windows.Forms.Padding(6);
            this.buchlöschen_btn.Name = "buchlöschen_btn";
            this.buchlöschen_btn.Size = new System.Drawing.Size(338, 56);
            this.buchlöschen_btn.TabIndex = 3;
            this.buchlöschen_btn.Text = "Buch löschen";
            this.buchlöschen_btn.UseVisualStyleBackColor = true;
            // 
            // Buchverwaltung_label
            // 
            this.Buchverwaltung_label.AutoSize = true;
            this.Buchverwaltung_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buchverwaltung_label.ForeColor = System.Drawing.Color.Red;
            this.Buchverwaltung_label.Location = new System.Drawing.Point(514, 24);
            this.Buchverwaltung_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Buchverwaltung_label.Name = "Buchverwaltung_label";
            this.Buchverwaltung_label.Size = new System.Drawing.Size(478, 51);
            this.Buchverwaltung_label.TabIndex = 9;
            this.Buchverwaltung_label.Text = "Bibliotheksmanagement";
            // 
            // zurück_btn
            // 
            this.zurück_btn.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zurück_btn.Location = new System.Drawing.Point(1149, 99);
            this.zurück_btn.Margin = new System.Windows.Forms.Padding(6);
            this.zurück_btn.Name = "zurück_btn";
            this.zurück_btn.Size = new System.Drawing.Size(338, 56);
            this.zurück_btn.TabIndex = 11;
            this.zurück_btn.Text = "Zurück";
            this.zurück_btn.UseVisualStyleBackColor = true;
            this.zurück_btn.Click += new System.EventHandler(this.btn_zurueck_Click);
            // 
            // Preiskategorie
            // 
            this.Preiskategorie.HeaderText = "Preiskategorie";
            this.Preiskategorie.MinimumWidth = 10;
            this.Preiskategorie.Name = "Preiskategorie";
            this.Preiskategorie.Width = 200;
            // 
            // Erscheinungsjahr
            // 
            this.Erscheinungsjahr.HeaderText = "Erscheinungsjahr";
            this.Erscheinungsjahr.MinimumWidth = 10;
            this.Erscheinungsjahr.Name = "Erscheinungsjahr";
            this.Erscheinungsjahr.Width = 200;
            // 
            // Seitenzahl
            // 
            this.Seitenzahl.HeaderText = "Seitenzahl";
            this.Seitenzahl.MinimumWidth = 10;
            this.Seitenzahl.Name = "Seitenzahl";
            this.Seitenzahl.Width = 200;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.MinimumWidth = 10;
            this.ISBN.Name = "ISBN";
            this.ISBN.Width = 200;
            // 
            // Titel
            // 
            this.Titel.HeaderText = "Titel";
            this.Titel.MinimumWidth = 10;
            this.Titel.Name = "Titel";
            this.Titel.Width = 200;
            // 
            // dGV_buchverwaltung
            // 
            this.dGV_buchverwaltung.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dGV_buchverwaltung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_buchverwaltung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titel,
            this.ISBN,
            this.Seitenzahl,
            this.Erscheinungsjahr,
            this.Preiskategorie});
            this.dGV_buchverwaltung.Location = new System.Drawing.Point(44, 183);
            this.dGV_buchverwaltung.Margin = new System.Windows.Forms.Padding(6);
            this.dGV_buchverwaltung.Name = "dGV_buchverwaltung";
            this.dGV_buchverwaltung.RowHeadersWidth = 82;
            this.dGV_buchverwaltung.Size = new System.Drawing.Size(1083, 525);
            this.dGV_buchverwaltung.TabIndex = 0;
            // 
            // Bibliotheksmanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 723);
            this.Controls.Add(this.zurück_btn);
            this.Controls.Add(this.Buchverwaltung_label);
            this.Controls.Add(this.buchlöschen_btn);
            this.Controls.Add(this.buchbearbeiten_btn);
            this.Controls.Add(this.btnhinzufügen_btn);
            this.Controls.Add(this.dGV_buchverwaltung);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Bibliotheksmanagement";
            this.Text = "Buchverwaltung";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_buchverwaltung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnhinzufügen_btn;
        private System.Windows.Forms.Button buchbearbeiten_btn;
        private System.Windows.Forms.Button buchlöschen_btn;
        private System.Windows.Forms.Label Buchverwaltung_label;
        private System.Windows.Forms.Button zurück_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preiskategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Erscheinungsjahr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seitenzahl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titel;
        private System.Windows.Forms.DataGridView dGV_buchverwaltung;
    }
}