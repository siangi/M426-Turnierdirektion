namespace Turnierdirektion
{
    partial class ErstellenView
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
            this.lstTeilnehmer = new System.Windows.Forms.ListView();
            this.cmbPunktesystem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHinzufuegen = new System.Windows.Forms.Button();
            this.btnEntfernen = new System.Windows.Forms.Button();
            this.btnTurnierErstellen = new System.Windows.Forms.Button();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTeilnehmer
            // 
            this.lstTeilnehmer.Location = new System.Drawing.Point(12, 112);
            this.lstTeilnehmer.Name = "lstTeilnehmer";
            this.lstTeilnehmer.Size = new System.Drawing.Size(417, 157);
            this.lstTeilnehmer.TabIndex = 0;
            this.lstTeilnehmer.UseCompatibleStateImageBehavior = false;
            // 
            // cmbPunktesystem
            // 
            this.cmbPunktesystem.FormattingEnabled = true;
            this.cmbPunktesystem.Location = new System.Drawing.Point(12, 39);
            this.cmbPunktesystem.Name = "cmbPunktesystem";
            this.cmbPunktesystem.Size = new System.Drawing.Size(316, 21);
            this.cmbPunktesystem.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Punktesystem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Teilnehmer";
            // 
            // btnHinzufuegen
            // 
            this.btnHinzufuegen.Location = new System.Drawing.Point(172, 83);
            this.btnHinzufuegen.Name = "btnHinzufuegen";
            this.btnHinzufuegen.Size = new System.Drawing.Size(75, 23);
            this.btnHinzufuegen.TabIndex = 4;
            this.btnHinzufuegen.Text = "Hinzufügen";
            this.btnHinzufuegen.UseVisualStyleBackColor = true;
            this.btnHinzufuegen.Click += new System.EventHandler(this.btnHinzufuegen_Click);
            // 
            // btnEntfernen
            // 
            this.btnEntfernen.Location = new System.Drawing.Point(253, 82);
            this.btnEntfernen.Name = "btnEntfernen";
            this.btnEntfernen.Size = new System.Drawing.Size(75, 23);
            this.btnEntfernen.TabIndex = 5;
            this.btnEntfernen.Text = "Entfernen";
            this.btnEntfernen.UseVisualStyleBackColor = true;
            this.btnEntfernen.Click += new System.EventHandler(this.btnEntfernen_Click);
            // 
            // btnTurnierErstellen
            // 
            this.btnTurnierErstellen.Location = new System.Drawing.Point(334, 296);
            this.btnTurnierErstellen.Name = "btnTurnierErstellen";
            this.btnTurnierErstellen.Size = new System.Drawing.Size(94, 23);
            this.btnTurnierErstellen.TabIndex = 6;
            this.btnTurnierErstellen.Text = "Turnier erstellen";
            this.btnTurnierErstellen.UseVisualStyleBackColor = true;
            this.btnTurnierErstellen.Click += new System.EventHandler(this.btnTurnierErstellen_Click);
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Location = new System.Drawing.Point(253, 296);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(75, 23);
            this.btnAbbrechen.TabIndex = 7;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // ErstellenView
            // 
            this.AcceptButton = this.btnHinzufuegen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 331);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.btnTurnierErstellen);
            this.Controls.Add(this.btnEntfernen);
            this.Controls.Add(this.btnHinzufuegen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPunktesystem);
            this.Controls.Add(this.lstTeilnehmer);
            this.Name = "ErstellenView";
            this.Text = "ErstellenView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstTeilnehmer;
        private System.Windows.Forms.ComboBox cmbPunktesystem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHinzufuegen;
        private System.Windows.Forms.Button btnEntfernen;
        private System.Windows.Forms.Button btnTurnierErstellen;
        private System.Windows.Forms.Button btnAbbrechen;
    }
}