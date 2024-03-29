namespace Bibliothek
{
    partial class Hauptmenü
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
            this.Startseite_label = new System.Windows.Forms.Label();
            this.Reiheninstandhaltung_btn = new System.Windows.Forms.Button();
            this.Kundenmanagement_btn = new System.Windows.Forms.Button();
            this.Ausleihmanagement_btn = new System.Windows.Forms.Button();
            this.Bibliotheksmanagement_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Startseite_label
            // 
            this.Startseite_label.AutoSize = true;
            this.Startseite_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Startseite_label.ForeColor = System.Drawing.Color.Red;
            this.Startseite_label.Location = new System.Drawing.Point(147, 9);
            this.Startseite_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Startseite_label.Name = "Startseite_label";
            this.Startseite_label.Size = new System.Drawing.Size(209, 51);
            this.Startseite_label.TabIndex = 9;
            this.Startseite_label.Text = "Startseite";
            
            // 
            // Reiheninstandhaltung_btn
            // 
            this.Reiheninstandhaltung_btn.Font = new System.Drawing.Font("Bahnschrift", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reiheninstandhaltung_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Reiheninstandhaltung_btn.Location = new System.Drawing.Point(79, 66);
            this.Reiheninstandhaltung_btn.Margin = new System.Windows.Forms.Padding(6);
            this.Reiheninstandhaltung_btn.Name = "Reiheninstandhaltung_btn";
            this.Reiheninstandhaltung_btn.Size = new System.Drawing.Size(343, 171);
            this.Reiheninstandhaltung_btn.TabIndex = 18;
            this.Reiheninstandhaltung_btn.Text = "Reiheninstandhaltung";
            this.Reiheninstandhaltung_btn.UseVisualStyleBackColor = true;
            this.Reiheninstandhaltung_btn.Click += new System.EventHandler(this.btn_buchreihenverwalten_Click);
            // 
            // Kundenmanagement_btn
            // 
            this.Kundenmanagement_btn.Font = new System.Drawing.Font("Bahnschrift", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kundenmanagement_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Kundenmanagement_btn.Location = new System.Drawing.Point(79, 439);
            this.Kundenmanagement_btn.Margin = new System.Windows.Forms.Padding(6);
            this.Kundenmanagement_btn.Name = "Kundenmanagement_btn";
            this.Kundenmanagement_btn.Size = new System.Drawing.Size(343, 171);
            this.Kundenmanagement_btn.TabIndex = 20;
            this.Kundenmanagement_btn.Text = "Kundenmanagement";
            this.Kundenmanagement_btn.UseVisualStyleBackColor = true;
            this.Kundenmanagement_btn.Click += new System.EventHandler(this.btn_kundenverwalten_Click);
            // 
            // Ausleihmanagement_btn
            // 
            this.Ausleihmanagement_btn.Font = new System.Drawing.Font("Bahnschrift", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ausleihmanagement_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Ausleihmanagement_btn.Location = new System.Drawing.Point(79, 622);
            this.Ausleihmanagement_btn.Margin = new System.Windows.Forms.Padding(6);
            this.Ausleihmanagement_btn.Name = "Ausleihmanagement_btn";
            this.Ausleihmanagement_btn.Size = new System.Drawing.Size(343, 171);
            this.Ausleihmanagement_btn.TabIndex = 22;
            this.Ausleihmanagement_btn.Text = "Ausleihmanagement";
            this.Ausleihmanagement_btn.UseVisualStyleBackColor = true;
            this.Ausleihmanagement_btn.Click += new System.EventHandler(this.btn_ausleihenverwalten_Click);
            // 
            // Bibliotheksmanagement_btn
            // 
            this.Bibliotheksmanagement_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bibliotheksmanagement_btn.Font = new System.Drawing.Font("Bahnschrift", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bibliotheksmanagement_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Bibliotheksmanagement_btn.Location = new System.Drawing.Point(79, 256);
            this.Bibliotheksmanagement_btn.Margin = new System.Windows.Forms.Padding(6);
            this.Bibliotheksmanagement_btn.Name = "Bibliotheksmanagement_btn";
            this.Bibliotheksmanagement_btn.Size = new System.Drawing.Size(343, 171);
            this.Bibliotheksmanagement_btn.TabIndex = 11;
            this.Bibliotheksmanagement_btn.Text = "Bibliotheksmanagement";
            this.Bibliotheksmanagement_btn.UseVisualStyleBackColor = true;
            this.Bibliotheksmanagement_btn.Click += new System.EventHandler(this.btn_buecherverwalten_Click);
            // 
            // Hauptmenü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 822);
            this.Controls.Add(this.Ausleihmanagement_btn);
            this.Controls.Add(this.Kundenmanagement_btn);
            this.Controls.Add(this.Reiheninstandhaltung_btn);
            this.Controls.Add(this.Bibliotheksmanagement_btn);
            this.Controls.Add(this.Startseite_label);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Hauptmenü";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Startseite_label;
        private System.Windows.Forms.Button Bibliotheksmanagement_btn;
        private System.Windows.Forms.Button Reiheninstandhaltung_btn;
        private System.Windows.Forms.Button Kundenmanagement_btn;
        private System.Windows.Forms.Button Ausleihmanagement_btn;
    }
}