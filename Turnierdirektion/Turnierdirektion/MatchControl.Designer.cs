namespace Turnierdirektion
{
    partial class MatchControl
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chkVerlaengerung = new System.Windows.Forms.CheckBox();
            this.txtGasttore = new System.Windows.Forms.TextBox();
            this.txtHeimtore = new System.Windows.Forms.TextBox();
            this.cmbGast = new System.Windows.Forms.ComboBox();
            this.cmbHeim = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(613, 8);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(64, 23);
            this.btnSpeichern.TabIndex = 17;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = ":";
            // 
            // chkVerlängerung
            // 
            this.chkVerlaengerung.AutoSize = true;
            this.chkVerlaengerung.Location = new System.Drawing.Point(489, 9);
            this.chkVerlaengerung.Name = "chkVerlängerung";
            this.chkVerlaengerung.Size = new System.Drawing.Size(118, 17);
            this.chkVerlaengerung.TabIndex = 15;
            this.chkVerlaengerung.Text = "Nach Verlängerung";
            this.chkVerlaengerung.UseVisualStyleBackColor = true;
            // 
            // txtGasttore
            // 
            this.txtGasttore.Location = new System.Drawing.Point(256, 8);
            this.txtGasttore.Name = "txtGasttore";
            this.txtGasttore.Size = new System.Drawing.Size(100, 20);
            this.txtGasttore.TabIndex = 14;
            // 
            // txtHeimtore
            // 
            this.txtHeimtore.Location = new System.Drawing.Point(134, 9);
            this.txtHeimtore.Name = "txtHeimtore";
            this.txtHeimtore.Size = new System.Drawing.Size(100, 20);
            this.txtHeimtore.TabIndex = 13;
            // 
            // cmbGast
            // 
            this.cmbGast.FormattingEnabled = true;
            this.cmbGast.Location = new System.Drawing.Point(362, 8);
            this.cmbGast.Name = "cmbGast";
            this.cmbGast.Size = new System.Drawing.Size(121, 21);
            this.cmbGast.TabIndex = 12;
            // 
            // cmbHeim
            // 
            this.cmbHeim.FormattingEnabled = true;
            this.cmbHeim.Location = new System.Drawing.Point(7, 8);
            this.cmbHeim.Name = "cmbHeim";
            this.cmbHeim.Size = new System.Drawing.Size(121, 21);
            this.cmbHeim.TabIndex = 11;
            // 
            // MatchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkVerlaengerung);
            this.Controls.Add(this.txtGasttore);
            this.Controls.Add(this.txtHeimtore);
            this.Controls.Add(this.cmbGast);
            this.Controls.Add(this.cmbHeim);
            this.Name = "MatchControl";
            this.Size = new System.Drawing.Size(687, 41);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkVerlaengerung;
        private System.Windows.Forms.TextBox txtGasttore;
        private System.Windows.Forms.TextBox txtHeimtore;
        private System.Windows.Forms.ComboBox cmbGast;
        private System.Windows.Forms.ComboBox cmbHeim;
    }
}
