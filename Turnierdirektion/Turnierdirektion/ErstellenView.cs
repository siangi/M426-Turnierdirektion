using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turnierdirektion
{
    /// <summary>
    /// Erstes Fenster das gezeigt wird, hier soll das Turnier erstellt,
    /// somit die Teams erfasst und das Punktesystem augewählt werden.
    /// </summary>
    public partial class ErstellenView : Form
    {
        public int SelectedPunkteSystem { get { return cmbPunktesystem.SelectedIndex; } }

        /// <summary>
        /// Liest alle Teilnehmer als Stringliste aus.
        /// </summary>
        public List<string> Teilnehmer
        {
            get
            {
                List<string> Result = new List<string>();

                for (int i = 0; i < lstTeilnehmer.Items.Count; i++)
                {
                    Result.Add(lstTeilnehmer.Items[i].Text);
                }
                
                return Result;
            }
        }

        public ErstellenView()
        {
            InitializeComponent();
        }

        public ErstellenView(string[] Punktesysteme)
        {
            InitializeComponent();
            cmbPunktesystem.Items.AddRange(Punktesysteme);
        }

        /// <summary>
        /// Fügt ein neuen Teilnhemer über den TeilnehmerDialog hinzu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHinzufuegen_Click(object sender, EventArgs e)
        {
            TeilnehmerDialog Dialog = new TeilnehmerDialog();
            string NewName = Dialog.Execute();

            if (!Teilnehmer.Contains(NewName))
            {
                lstTeilnehmer.Items.Add(NewName);
            }
        }

        /// <summary>
        /// Entfernt den ausgewählten Teilnehmer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEntfernen_Click(object sender, EventArgs e)
        {
            if (lstTeilnehmer.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lstTeilnehmer.SelectedItems)
                {
                    item.Remove();
                }
            }
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTurnierErstellen_Click(object sender, EventArgs e)
        {
            if (cmbPunktesystem.SelectedIndex == -1)
            {
                cmbPunktesystem.Focus();
                cmbPunktesystem.DroppedDown = true;
                return;
            }

            if (Teilnehmer.Count < 2)
            {
                btnHinzufuegen_Click(btnHinzufuegen, e);
                return;
            }

            this.Close();
        }
    }
}
