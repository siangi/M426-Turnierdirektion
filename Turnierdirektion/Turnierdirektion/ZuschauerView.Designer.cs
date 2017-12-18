namespace Turnierdirektion
{
    partial class ZuschauerView
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
            this.lstTabelle = new System.Windows.Forms.ListView();
            this.colRang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTeilnehmer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPunkte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstTabelle
            // 
            this.lstTabelle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRang,
            this.colTeilnehmer,
            this.colPunkte});
            this.lstTabelle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTabelle.Location = new System.Drawing.Point(0, 0);
            this.lstTabelle.Name = "lstTabelle";
            this.lstTabelle.Size = new System.Drawing.Size(433, 393);
            this.lstTabelle.TabIndex = 0;
            this.lstTabelle.UseCompatibleStateImageBehavior = false;
            this.lstTabelle.View = System.Windows.Forms.View.Details;
            // 
            // colRang
            // 
            this.colRang.Text = "Rang";
            // 
            // colTeilnehmer
            // 
            this.colTeilnehmer.Text = "Teilnehmer";
            this.colTeilnehmer.Width = 84;
            // 
            // colPunkte
            // 
            this.colPunkte.Text = "Punkte";
            // 
            // ZuschauerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 393);
            this.Controls.Add(this.lstTabelle);
            this.Name = "ZuschauerView";
            this.Text = "Zuschauer View";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstTabelle;
        private System.Windows.Forms.ColumnHeader colRang;
        private System.Windows.Forms.ColumnHeader colTeilnehmer;
        private System.Windows.Forms.ColumnHeader colPunkte;
    }
}

