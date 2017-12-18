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
    public partial class DirektionView : Form, IObserver
    {

        List<Teilnehmer> Teilnehmerliste;
        private TTurnier Model = null;

        public DirektionView(TTurnier Model, List<Teilnehmer> teilnehmerliste)
        {
            InitializeComponent();
            Teilnehmerliste = teilnehmerliste;
            this.Model = Model;
        }

        public void OnModelPropertyChanged(string PropertyMessage)
        {

        }

        private void btnHinzufuegen_Click(object sender, EventArgs e)
        {
            MatchControl MatchCont = new MatchControl(Teilnehmerliste);
            MatchCont.OnSaveMatch += Model.OnMatchSave;
            pnlMatches.Controls.Add(MatchCont);
        }
    }
}
