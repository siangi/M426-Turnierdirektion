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
    /// Übersicht für die Turnierdirektion, hier werden die Matches verwaltet.
    /// </summary>
    public partial class DirektionView : Form, IObserver
    {

        private List<Teilnehmer> Teilnehmerliste;
        private Turnier Model = null;

        public DirektionView(Turnier Model, List<Teilnehmer> teilnehmerliste)
        {
            InitializeComponent();
            Teilnehmerliste = teilnehmerliste;
            this.Model = Model;
        }

        /// <summary>
        /// Siehe Interface IObserver
        /// </summary>
        /// <param name="PropertyMessage"></param>
        public void OnModelPropertyChanged(string PropertyMessage)
        {

        }

        /// <summary>
        /// Fügt ein neues Match zur Übersicht hinzu, und managed was passiert, wenn es gespeichert wird.
        /// </summary>
        /// <param name="sender">Standard</param>
        /// <param name="e">Standard</param>
        private void btnHinzufuegen_Click(object sender, EventArgs e)
        {
            MatchControl MatchCont = new MatchControl(Teilnehmerliste);
            MatchCont.OnSaveMatch += Model.OnMatchSave;
            pnlMatches.Controls.Add(MatchCont);
        }
    }
}
