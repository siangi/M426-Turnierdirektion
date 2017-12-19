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
            this.btnSpeichern.Location = new System.Drawing.Point(817, 10);
            this.btnSpeichern.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(85, 28);
            this.btnSpeichern.TabIndex = 5;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = ":";
            // 
            // chkVerlaengerung
            // 
            this.chkVerlaengerung.AutoSize = true;
            this.chkVerlaengerung.Location = new System.Drawing.Point(652, 11);
            this.chkVerlaengerung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkVerlaengerung.Name = "chkVerlaengerung";
            this.chkVerlaengerung.Size = new System.Drawing.Size(153, 21);
            this.chkVerlaengerung.TabIndex = 4;
            this.chkVerlaengerung.Text = "Nach Verlängerung";
            this.chkVerlaengerung.UseVisualStyleBackColor = true;
            // 
            // txtGasttore
            // 
            this.txtGasttore.Location = new System.Drawing.Point(341, 10);
            this.txtGasttore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGasttore.Name = "txtGasttore";
            this.txtGasttore.Size = new System.Drawing.Size(132, 22);
            this.txtGasttore.TabIndex = 2;
            // 
            // txtHeimtore
            // 
            this.txtHeimtore.Location = new System.Drawing.Point(179, 11);
            this.txtHeimtore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHeimtore.Name = "txtHeimtore";
            this.txtHeimtore.Size = new System.Drawing.Size(132, 22);
            this.txtHeimtore.TabIndex = 1;
            // 
            // cmbGast
            // 
            this.cmbGast.FormattingEnabled = true;
            this.cmbGast.Location = new System.Drawing.Point(483, 10);
            this.cmbGast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbGast.Name = "cmbGast";
            this.cmbGast.Size = new System.Drawing.Size(160, 24);
            this.cmbGast.TabIndex = 3;
            // 
            // cmbHeim
            // 
            this.cmbHeim.FormattingEnabled = true;
            this.cmbHeim.Location = new System.Drawing.Point(9, 10);
            this.cmbHeim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbHeim.Name = "cmbHeim";
            this.cmbHeim.Size = new System.Drawing.Size(160, 24);
            this.cmbHeim.TabIndex = 0;
            // 
            // MatchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkVerlaengerung);
            this.Controls.Add(this.txtGasttore);
            this.Controls.Add(this.txtHeimtore);
            this.Controls.Add(this.cmbGast);
            this.Controls.Add(this.cmbHeim);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MatchControl";
            this.Size = new System.Drawing.Size(916, 50);
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
